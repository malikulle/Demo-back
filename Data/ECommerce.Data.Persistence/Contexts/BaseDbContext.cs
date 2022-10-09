using ECommerce.Data.Domain.AddressBook;
using ECommerce.Data.Domain.Catalog;
using ECommerce.Data.Domain.Configuration;
using ECommerce.Data.Domain.Enums.Logging;
using ECommerce.Data.Domain.Logging;
using ECommerce.Data.Domain.Membership;
using ECommerce.Data.Domain.Sales;
using ECommerce.Data.Persistence.Logging;
using ECommerce.Framework.SharedLibary.Attributes;
using ECommerce.Framework.SharedLibary.Domain.Base;
using ECommerce.Framework.SharedLibary.Token;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ECommerce.Data.Persistence.Contexts
{
    public class BaseDbContext : DbContext
    {

        private readonly IHttpContextAccessor _httpContext;

        public BaseDbContext(DbContextOptions dbContextOptions, IHttpContextAccessor httpContext) : base(dbContextOptions)
        {
            _httpContext = httpContext;
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>().HasData(SeedDatabase.GetCountries());
            modelBuilder.Entity<City>().HasData(SeedDatabase.GetCities());
            modelBuilder.Entity<Role>().HasData(SeedDatabase.GetRoles());
            modelBuilder.Entity<User>().HasData(SeedDatabase.GetUsers());
            modelBuilder.Entity<Language>().HasData(SeedDatabase.GetLanguages());
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Product_i18n> Product_i18ns { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Category_i18n> Category_i18ns { get; set; }
        public DbSet<ProductComment> ProductComments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolePermission> RolePermissions { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Parameter> Parameters { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<ExceptionLog> ExceptionLogs { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobExecution> JobExecutions { get; set; }
        public DbSet<JobExecutionDetail> JobExecutionDetails { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }

        public override int SaveChanges()
        {
            OnBeforeSaveChanges();
            SetUserID();
            return base.SaveChanges();
        }

        public void SetUserID()
        {
            var entries = ChangeTracker.Entries().Where(e => e.Entity is DataEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));
            long userID = this.GetCurrentUserID();
            foreach (var entityEntry in entries)
            {
                if (entityEntry.State == EntityState.Added)
                {
                    ((DataEntity)entityEntry.Entity).UserCreatedID = userID;
                }
                else if (entityEntry.State == EntityState.Modified)
                {
                    ((DataEntity)entityEntry.Entity).UserModifiedID = userID;
                }
            }
        }
        public void OnBeforeSaveChanges()
        {

            var userId = this.GetCurrentUserID().ToString();
            this.ChangeTracker.DetectChanges();
            var auditEntries = new List<AuditEntry>();
            foreach (var entry in this.ChangeTracker.Entries())
            {
                if (entry.Entity is AuditLog || entry.State == EntityState.Detached || entry.State == EntityState.Unchanged)
                    continue;

                bool enable = false;

                var auditLoggingAttribute = entry.Entity.GetType().GetCustomAttributes(typeof(AuditLoggingAttribute), true).FirstOrDefault() as AuditLoggingAttribute;
                if (auditLoggingAttribute != null)
                {
                    enable = auditLoggingAttribute.Enable;
                }

                if (!enable)
                    continue;

                var auditEntry = new AuditEntry(entry);
                auditEntry.TableName = entry.Entity.GetType().Name;
                auditEntry.UserId = userId;
                auditEntries.Add(auditEntry);
                foreach (var property in entry.Properties)
                {

                    string propertyName = property.Metadata.Name;
                    if (property.Metadata.IsPrimaryKey())
                    {
                        auditEntry.KeyValues[propertyName] = property.CurrentValue;
                        continue;
                    }
                    switch (entry.State)
                    {
                        case EntityState.Added:
                            auditEntry.AuditType = AuditType.Create;
                            auditEntry.NewValues[propertyName] = property.CurrentValue;
                            break;
                        case EntityState.Deleted:
                            auditEntry.AuditType = AuditType.Delete;
                            auditEntry.OldValues[propertyName] = property.OriginalValue;
                            break;
                        case EntityState.Modified:
                            if (property.IsModified)
                            {
                                auditEntry.ChangedColumns.Add(propertyName);
                                auditEntry.AuditType = AuditType.Update;
                                auditEntry.OldValues[propertyName] = property.OriginalValue;
                                auditEntry.NewValues[propertyName] = property.CurrentValue;
                            }
                            break;
                    }
                }
            }
            foreach (var auditEntry in auditEntries)
            {
                AuditLogs.Add(auditEntry.ToAudit());
            }
        }

        public long GetCurrentUserID()
        {
            try
            {
                if (_httpContext.HttpContext != null)
                    return Convert.ToInt64(_httpContext.HttpContext.User.Claims.FirstOrDefault(x => x.Type == ECommerceClaimTypes.UserID)?.Value);
            }
            catch (Exception)
            {
            }
            return 0;
        }

    }

}
