using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ECommerce.Data.Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Logging");

            migrationBuilder.EnsureSchema(
                name: "Sales");

            migrationBuilder.EnsureSchema(
                name: "Catalog");

            migrationBuilder.EnsureSchema(
                name: "AddressBook");

            migrationBuilder.EnsureSchema(
                name: "Configuration");

            migrationBuilder.EnsureSchema(
                name: "Membership");

            migrationBuilder.CreateTable(
                name: "AuditLog",
                schema: "Logging",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserID = table.Column<string>(type: "text", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: true),
                    TableName = table.Column<string>(type: "text", nullable: true),
                    OldValues = table.Column<string>(type: "text", nullable: true),
                    NewValues = table.Column<string>(type: "text", nullable: true),
                    AffectedColumns = table.Column<string>(type: "text", nullable: true),
                    PrimaryKey = table.Column<string>(type: "text", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserCreatedID = table.Column<long>(type: "bigint", nullable: false),
                    UserModifiedID = table.Column<long>(type: "bigint", nullable: false),
                    StatusID = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuditLog", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                schema: "Catalog",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserCreatedID = table.Column<long>(type: "bigint", nullable: false),
                    UserModifiedID = table.Column<long>(type: "bigint", nullable: false),
                    StatusID = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                schema: "AddressBook",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CodeISO = table.Column<string>(type: "text", nullable: true),
                    CodeISO3 = table.Column<string>(type: "text", nullable: true),
                    PhoneCode = table.Column<string>(type: "text", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserCreatedID = table.Column<long>(type: "bigint", nullable: false),
                    UserModifiedID = table.Column<long>(type: "bigint", nullable: false),
                    StatusID = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ExceptionLog",
                schema: "Logging",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: true),
                    StackTrace = table.Column<string>(type: "text", nullable: true),
                    IPAddress = table.Column<string>(type: "text", nullable: true),
                    MachineName = table.Column<string>(type: "text", nullable: true),
                    UserAgent = table.Column<string>(type: "text", nullable: true),
                    SessionID = table.Column<string>(type: "text", nullable: true),
                    FunctionName = table.Column<string>(type: "text", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserCreatedID = table.Column<long>(type: "bigint", nullable: false),
                    UserModifiedID = table.Column<long>(type: "bigint", nullable: false),
                    StatusID = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExceptionLog", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Job",
                schema: "Configuration",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserCreatedID = table.Column<long>(type: "bigint", nullable: false),
                    UserModifiedID = table.Column<long>(type: "bigint", nullable: false),
                    StatusID = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Job", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                schema: "Configuration",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CultureCode = table.Column<string>(type: "text", nullable: true),
                    IsoCode = table.Column<string>(type: "text", nullable: true),
                    ImagePath = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    IconName = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserCreatedID = table.Column<long>(type: "bigint", nullable: false),
                    UserModifiedID = table.Column<long>(type: "bigint", nullable: false),
                    StatusID = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Parameter",
                schema: "Configuration",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Module = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Value = table.Column<string>(type: "text", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserCreatedID = table.Column<long>(type: "bigint", nullable: false),
                    UserModifiedID = table.Column<long>(type: "bigint", nullable: false),
                    StatusID = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parameter", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Permission",
                schema: "Membership",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserCreatedID = table.Column<long>(type: "bigint", nullable: false),
                    UserModifiedID = table.Column<long>(type: "bigint", nullable: false),
                    StatusID = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permission", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                schema: "Membership",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserCreatedID = table.Column<long>(type: "bigint", nullable: false),
                    UserModifiedID = table.Column<long>(type: "bigint", nullable: false),
                    StatusID = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                schema: "Catalog",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    CategoryID = table.Column<long>(type: "bigint", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserCreatedID = table.Column<long>(type: "bigint", nullable: false),
                    UserModifiedID = table.Column<long>(type: "bigint", nullable: false),
                    StatusID = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalSchema: "Catalog",
                        principalTable: "Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "City",
                schema: "AddressBook",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    PlateCode = table.Column<string>(type: "text", nullable: true),
                    CountryID = table.Column<long>(type: "bigint", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserCreatedID = table.Column<long>(type: "bigint", nullable: false),
                    UserModifiedID = table.Column<long>(type: "bigint", nullable: false),
                    StatusID = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.ID);
                    table.ForeignKey(
                        name: "FK_City_Country_CountryID",
                        column: x => x.CountryID,
                        principalSchema: "AddressBook",
                        principalTable: "Country",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobExecution",
                schema: "Configuration",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    StartDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    EndDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    JobExecutionType = table.Column<byte>(type: "smallint", nullable: false),
                    JobID = table.Column<long>(type: "bigint", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserCreatedID = table.Column<long>(type: "bigint", nullable: false),
                    UserModifiedID = table.Column<long>(type: "bigint", nullable: false),
                    StatusID = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobExecution", x => x.ID);
                    table.ForeignKey(
                        name: "FK_JobExecution_Job_JobID",
                        column: x => x.JobID,
                        principalSchema: "Configuration",
                        principalTable: "Job",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Category_i18n",
                schema: "Catalog",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CategoryID = table.Column<long>(type: "bigint", nullable: false),
                    LanguageID = table.Column<long>(type: "bigint", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserCreatedID = table.Column<long>(type: "bigint", nullable: false),
                    UserModifiedID = table.Column<long>(type: "bigint", nullable: false),
                    StatusID = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category_i18n", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Category_i18n_Category_CategoryID",
                        column: x => x.CategoryID,
                        principalSchema: "Catalog",
                        principalTable: "Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Category_i18n_Language_LanguageID",
                        column: x => x.LanguageID,
                        principalSchema: "Configuration",
                        principalTable: "Language",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RolePermission",
                schema: "Membership",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleID = table.Column<long>(type: "bigint", nullable: false),
                    PermissionID = table.Column<long>(type: "bigint", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserCreatedID = table.Column<long>(type: "bigint", nullable: false),
                    UserModifiedID = table.Column<long>(type: "bigint", nullable: false),
                    StatusID = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RolePermission", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RolePermission_Permission_PermissionID",
                        column: x => x.PermissionID,
                        principalSchema: "Membership",
                        principalTable: "Permission",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RolePermission_Role_RoleID",
                        column: x => x.RoleID,
                        principalSchema: "Membership",
                        principalTable: "Role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "User",
                schema: "Membership",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Surname = table.Column<string>(type: "text", nullable: true),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    EmailAddress = table.Column<string>(type: "text", nullable: true),
                    ImagePath = table.Column<string>(type: "text", nullable: true),
                    IsGlobalAdmin = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "bytea", nullable: true),
                    PasswordHash = table.Column<byte[]>(type: "bytea", nullable: true),
                    RoleID = table.Column<long>(type: "bigint", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserCreatedID = table.Column<long>(type: "bigint", nullable: false),
                    UserModifiedID = table.Column<long>(type: "bigint", nullable: false),
                    StatusID = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleID",
                        column: x => x.RoleID,
                        principalSchema: "Membership",
                        principalTable: "Role",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Product_i18n",
                schema: "Catalog",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    ProductID = table.Column<long>(type: "bigint", nullable: false),
                    LanguageID = table.Column<long>(type: "bigint", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserCreatedID = table.Column<long>(type: "bigint", nullable: false),
                    UserModifiedID = table.Column<long>(type: "bigint", nullable: false),
                    StatusID = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_i18n", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_i18n_Language_LanguageID",
                        column: x => x.LanguageID,
                        principalSchema: "Configuration",
                        principalTable: "Language",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_i18n_Product_ProductID",
                        column: x => x.ProductID,
                        principalSchema: "Catalog",
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobExecutionDetail",
                schema: "Configuration",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Description = table.Column<string>(type: "text", nullable: true),
                    JobExecutionID = table.Column<long>(type: "bigint", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserCreatedID = table.Column<long>(type: "bigint", nullable: false),
                    UserModifiedID = table.Column<long>(type: "bigint", nullable: false),
                    StatusID = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobExecutionDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_JobExecutionDetail_JobExecution_JobExecutionID",
                        column: x => x.JobExecutionID,
                        principalSchema: "Configuration",
                        principalTable: "JobExecution",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Basket",
                schema: "Sales",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
                    PaymentMethod = table.Column<byte>(type: "smallint", nullable: false),
                    BasketStatus = table.Column<byte>(type: "smallint", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    BasketPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    TaxPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    ShippingPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserCreatedID = table.Column<long>(type: "bigint", nullable: false),
                    UserModifiedID = table.Column<long>(type: "bigint", nullable: false),
                    StatusID = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basket", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Basket_User_UserID",
                        column: x => x.UserID,
                        principalSchema: "Membership",
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductComment",
                schema: "Catalog",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(type: "text", nullable: true),
                    ProductID = table.Column<long>(type: "bigint", nullable: false),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserCreatedID = table.Column<long>(type: "bigint", nullable: false),
                    UserModifiedID = table.Column<long>(type: "bigint", nullable: false),
                    StatusID = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductComment", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ProductComment_Product_ProductID",
                        column: x => x.ProductID,
                        principalSchema: "Catalog",
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductComment_User_UserID",
                        column: x => x.UserID,
                        principalSchema: "Membership",
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BasketItem",
                schema: "Sales",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    TotalPrice = table.Column<decimal>(type: "numeric", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Quantity = table.Column<int>(type: "integer", nullable: false),
                    ProductID = table.Column<long>(type: "bigint", nullable: false),
                    BasketID = table.Column<long>(type: "bigint", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DateModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserCreatedID = table.Column<long>(type: "bigint", nullable: false),
                    UserModifiedID = table.Column<long>(type: "bigint", nullable: false),
                    StatusID = table.Column<byte>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BasketItem_Basket_BasketID",
                        column: x => x.BasketID,
                        principalSchema: "Sales",
                        principalTable: "Basket",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketItem_Product_ProductID",
                        column: x => x.ProductID,
                        principalSchema: "Catalog",
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Category",
                columns: new[] { "ID", "DateCreated", "DateModified", "Name", "StatusID", "UserCreatedID", "UserModifiedID" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 10, 16, 18, 32, 33, 879, DateTimeKind.Local).AddTicks(7560), new DateTime(2022, 10, 16, 18, 32, 33, 879, DateTimeKind.Local).AddTicks(7569), "Telefon", (byte)1, 0L, 0L },
                    { 2L, new DateTime(2022, 10, 16, 18, 32, 33, 879, DateTimeKind.Local).AddTicks(7571), new DateTime(2022, 10, 16, 18, 32, 33, 879, DateTimeKind.Local).AddTicks(7572), "Bilgisayar", (byte)1, 0L, 0L }
                });

            migrationBuilder.InsertData(
                schema: "AddressBook",
                table: "Country",
                columns: new[] { "ID", "CodeISO", "CodeISO3", "DateCreated", "DateModified", "Name", "PhoneCode", "StatusID", "UserCreatedID", "UserModifiedID" },
                values: new object[] { 1L, "TR", "TUR", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Türkiye", "90", (byte)1, 0L, 0L });

            migrationBuilder.InsertData(
                schema: "Configuration",
                table: "Language",
                columns: new[] { "ID", "CultureCode", "DateCreated", "DateModified", "IconName", "ImagePath", "IsoCode", "Name", "StatusID", "UserCreatedID", "UserModifiedID" },
                values: new object[,]
                {
                    { 1L, "tr", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "tr", "Türkçe", (byte)1, 0L, 0L },
                    { 2L, "en", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "en", "English", (byte)1, 0L, 0L }
                });

            migrationBuilder.InsertData(
                schema: "Membership",
                table: "Role",
                columns: new[] { "ID", "DateCreated", "DateModified", "Name", "StatusID", "UserCreatedID", "UserModifiedID" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", (byte)1, 0L, 0L },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", (byte)1, 0L, 0L }
                });

            migrationBuilder.InsertData(
                schema: "AddressBook",
                table: "City",
                columns: new[] { "ID", "CountryID", "DateCreated", "DateModified", "Name", "PlateCode", "StatusID", "UserCreatedID", "UserModifiedID" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adana", "01", (byte)1, 0L, 0L },
                    { 2L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adıyaman", "02", (byte)1, 0L, 0L },
                    { 3L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Afyon", "03", (byte)1, 0L, 0L },
                    { 4L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ağrı", "04", (byte)1, 0L, 0L },
                    { 5L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amasya", "05", (byte)1, 0L, 0L },
                    { 6L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ankara", "06", (byte)1, 0L, 0L },
                    { 7L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Antalya", "07", (byte)1, 0L, 0L },
                    { 8L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Artvin", "08", (byte)1, 0L, 0L },
                    { 9L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aydın", "09", (byte)1, 0L, 0L },
                    { 10L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Balıkesir", "10", (byte)1, 0L, 0L },
                    { 11L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bilecik", "11", (byte)1, 0L, 0L },
                    { 12L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bingöl", "12", (byte)1, 0L, 0L },
                    { 13L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bitlis", "13", (byte)1, 0L, 0L },
                    { 14L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bolu", "14", (byte)1, 0L, 0L },
                    { 15L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Burdur", "15", (byte)1, 0L, 0L },
                    { 16L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bursa", "16", (byte)1, 0L, 0L },
                    { 17L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Çanakkale", "17", (byte)1, 0L, 0L },
                    { 18L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Çankırı", "18", (byte)1, 0L, 0L },
                    { 19L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Çorum", "19", (byte)1, 0L, 0L },
                    { 20L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Denizli", "20", (byte)1, 0L, 0L },
                    { 21L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Diyarbakır", "21", (byte)1, 0L, 0L },
                    { 22L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Edirne", "22", (byte)1, 0L, 0L },
                    { 23L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elazığ", "23", (byte)1, 0L, 0L },
                    { 24L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Erzincan", "24", (byte)1, 0L, 0L },
                    { 25L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Erzurum", "25", (byte)1, 0L, 0L },
                    { 26L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eskişehir", "26", (byte)1, 0L, 0L },
                    { 27L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gaziantep", "27", (byte)1, 0L, 0L },
                    { 28L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Giresun", "28", (byte)1, 0L, 0L },
                    { 29L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gümüşhane", "29", (byte)1, 0L, 0L },
                    { 30L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hakkari", "30", (byte)1, 0L, 0L },
                    { 31L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hatay", "31", (byte)1, 0L, 0L },
                    { 32L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Isparta", "32", (byte)1, 0L, 0L },
                    { 33L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İçel", "33", (byte)1, 0L, 0L },
                    { 34L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İstanbul", "34", (byte)1, 0L, 0L },
                    { 35L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "İzmir", "35", (byte)1, 0L, 0L },
                    { 36L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kars", "36", (byte)1, 0L, 0L },
                    { 37L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kastamonu", "37", (byte)1, 0L, 0L },
                    { 38L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kayseri", "38", (byte)1, 0L, 0L },
                    { 39L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kırklareli", "39", (byte)1, 0L, 0L },
                    { 40L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kırşehir", "40", (byte)1, 0L, 0L },
                    { 41L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kocaeli", "41", (byte)1, 0L, 0L },
                    { 42L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Konya", "42", (byte)1, 0L, 0L },
                    { 43L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kütahya", "43", (byte)1, 0L, 0L },
                    { 44L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Malatya", "44", (byte)1, 0L, 0L },
                    { 45L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manisa", "45", (byte)1, 0L, 0L },
                    { 46L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kahramanmaraş", "46", (byte)1, 0L, 0L },
                    { 47L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mardin", "47", (byte)1, 0L, 0L },
                    { 48L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Muğla", "48", (byte)1, 0L, 0L },
                    { 49L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Muş", "49", (byte)1, 0L, 0L },
                    { 50L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nevşehir", "50", (byte)1, 0L, 0L },
                    { 51L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Niğde", "51", (byte)1, 0L, 0L },
                    { 52L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ordu", "52", (byte)1, 0L, 0L },
                    { 53L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rize", "53", (byte)1, 0L, 0L },
                    { 54L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sakarya", "54", (byte)1, 0L, 0L },
                    { 55L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsun", "55", (byte)1, 0L, 0L },
                    { 56L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Siirt", "56", (byte)1, 0L, 0L },
                    { 57L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sinop", "57", (byte)1, 0L, 0L },
                    { 58L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sivas", "58", (byte)1, 0L, 0L },
                    { 59L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tekirdağ", "59", (byte)1, 0L, 0L },
                    { 60L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tokat", "60", (byte)1, 0L, 0L },
                    { 61L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Trabzon", "61", (byte)1, 0L, 0L },
                    { 62L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tunceli", "62", (byte)1, 0L, 0L },
                    { 63L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Şanlıurfa", "63", (byte)1, 0L, 0L },
                    { 64L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Uşak", "64", (byte)1, 0L, 0L },
                    { 65L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Van", "65", (byte)1, 0L, 0L },
                    { 66L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yozgat", "66", (byte)1, 0L, 0L },
                    { 67L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zonguldak", "67", (byte)1, 0L, 0L },
                    { 68L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aksaray", "68", (byte)1, 0L, 0L },
                    { 69L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bayburt", "69", (byte)1, 0L, 0L },
                    { 70L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karaman", "70", (byte)1, 0L, 0L },
                    { 71L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kırıkkale", "71", (byte)1, 0L, 0L },
                    { 72L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Batman", "72", (byte)1, 0L, 0L },
                    { 73L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Şırnak", "73", (byte)1, 0L, 0L },
                    { 74L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bartın", "74", (byte)1, 0L, 0L },
                    { 75L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ardahan", "75", (byte)1, 0L, 0L },
                    { 76L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Iğdır", "76", (byte)1, 0L, 0L },
                    { 77L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yalova", "77", (byte)1, 0L, 0L },
                    { 78L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karabük", "78", (byte)1, 0L, 0L },
                    { 79L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kilis", "79", (byte)1, 0L, 0L },
                    { 80L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Osmaniye", "80", (byte)1, 0L, 0L },
                    { 81L, 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Düzce", "81", (byte)1, 0L, 0L }
                });

            migrationBuilder.InsertData(
                schema: "Catalog",
                table: "Product",
                columns: new[] { "ID", "CategoryID", "DateCreated", "DateModified", "Description", "ImagePath", "Name", "Price", "StatusID", "UserCreatedID", "UserModifiedID" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2022, 10, 16, 18, 32, 33, 879, DateTimeKind.Local).AddTicks(7591), new DateTime(2022, 10, 16, 18, 32, 33, 879, DateTimeKind.Local).AddTicks(7592), null, "/Data/TempImg/1.jpg", "Samsung S5", 2000m, (byte)1, 0L, 0L },
                    { 2L, 1L, new DateTime(2022, 10, 16, 18, 32, 33, 879, DateTimeKind.Local).AddTicks(7594), new DateTime(2022, 10, 16, 18, 32, 33, 879, DateTimeKind.Local).AddTicks(7595), null, "/Data/TempImg/2.jpg", "Samsung S6", 3000m, (byte)1, 0L, 0L },
                    { 3L, 1L, new DateTime(2022, 10, 16, 18, 32, 33, 879, DateTimeKind.Local).AddTicks(7596), new DateTime(2022, 10, 16, 18, 32, 33, 879, DateTimeKind.Local).AddTicks(7596), null, "/Data/TempImg/3.jpg", "Samsung S7", 4000m, (byte)1, 0L, 0L },
                    { 4L, 1L, new DateTime(2022, 10, 16, 18, 32, 33, 879, DateTimeKind.Local).AddTicks(7598), new DateTime(2022, 10, 16, 18, 32, 33, 879, DateTimeKind.Local).AddTicks(7598), null, "/Data/TempImg/4.jpg", "Samsung S8", 5000m, (byte)1, 0L, 0L },
                    { 5L, 1L, new DateTime(2022, 10, 16, 18, 32, 33, 879, DateTimeKind.Local).AddTicks(7599), new DateTime(2022, 10, 16, 18, 32, 33, 879, DateTimeKind.Local).AddTicks(7600), null, "/Data/TempImg/5.jpg", "Samsung S9", 6000m, (byte)1, 0L, 0L },
                    { 6L, 2L, new DateTime(2022, 10, 16, 18, 32, 33, 879, DateTimeKind.Local).AddTicks(7602), new DateTime(2022, 10, 16, 18, 32, 33, 879, DateTimeKind.Local).AddTicks(7603), null, "/Data/TempImg/6.jpg", "IPhone 6", 4000m, (byte)1, 0L, 0L },
                    { 7L, 2L, new DateTime(2022, 10, 16, 18, 32, 33, 879, DateTimeKind.Local).AddTicks(7604), new DateTime(2022, 10, 16, 18, 32, 33, 879, DateTimeKind.Local).AddTicks(7604), null, "/Data/TempImg/6.jpg", "IPhone 7", 5000m, (byte)1, 0L, 0L }
                });

            migrationBuilder.InsertData(
                schema: "Membership",
                table: "User",
                columns: new[] { "ID", "DateCreated", "DateModified", "EmailAddress", "FullName", "ImagePath", "IsGlobalAdmin", "Name", "PasswordHash", "PasswordSalt", "RoleID", "StatusID", "Surname", "UserCreatedID", "UserModifiedID" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", "Admin Admin", null, true, "Admin", new byte[] { 97, 216, 200, 125, 245, 90, 96, 192, 134, 223, 241, 3, 44, 173, 18, 154, 160, 0, 47, 72, 217, 200, 82, 98, 199, 116, 63, 82, 3, 20, 242, 176, 116, 249, 168, 157, 36, 88, 68, 213, 62, 33, 19, 48, 106, 136, 228, 237, 65, 109, 234, 168, 199, 249, 33, 158, 47, 169, 51, 22, 205, 103, 203, 243 }, new byte[] { 128, 74, 237, 184, 4, 55, 154, 183, 173, 6, 201, 37, 142, 144, 3, 41, 28, 19, 66, 167, 11, 42, 128, 123, 130, 211, 220, 43, 234, 18, 95, 129, 49, 147, 239, 25, 116, 134, 56, 5, 117, 123, 26, 21, 99, 143, 35, 111, 24, 179, 204, 221, 192, 115, 192, 177, 241, 217, 227, 30, 111, 53, 84, 190, 147, 200, 206, 242, 255, 134, 46, 183, 46, 194, 9, 116, 172, 204, 57, 121, 230, 60, 54, 255, 105, 23, 90, 95, 168, 234, 138, 14, 122, 23, 15, 95, 156, 143, 77, 147, 139, 122, 122, 155, 172, 114, 88, 130, 50, 44, 182, 68, 216, 198, 99, 22, 22, 71, 95, 86, 203, 88, 139, 6, 100, 218, 28, 154 }, 1L, (byte)1, "Admin", 0L, 0L },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@user.com", "User User", null, false, "User", new byte[] { 97, 216, 200, 125, 245, 90, 96, 192, 134, 223, 241, 3, 44, 173, 18, 154, 160, 0, 47, 72, 217, 200, 82, 98, 199, 116, 63, 82, 3, 20, 242, 176, 116, 249, 168, 157, 36, 88, 68, 213, 62, 33, 19, 48, 106, 136, 228, 237, 65, 109, 234, 168, 199, 249, 33, 158, 47, 169, 51, 22, 205, 103, 203, 243 }, new byte[] { 128, 74, 237, 184, 4, 55, 154, 183, 173, 6, 201, 37, 142, 144, 3, 41, 28, 19, 66, 167, 11, 42, 128, 123, 130, 211, 220, 43, 234, 18, 95, 129, 49, 147, 239, 25, 116, 134, 56, 5, 117, 123, 26, 21, 99, 143, 35, 111, 24, 179, 204, 221, 192, 115, 192, 177, 241, 217, 227, 30, 111, 53, 84, 190, 147, 200, 206, 242, 255, 134, 46, 183, 46, 194, 9, 116, 172, 204, 57, 121, 230, 60, 54, 255, 105, 23, 90, 95, 168, 234, 138, 14, 122, 23, 15, 95, 156, 143, 77, 147, 139, 122, 122, 155, 172, 114, 88, 130, 50, 44, 182, 68, 216, 198, 99, 22, 22, 71, 95, 86, 203, 88, 139, 6, 100, 218, 28, 154 }, 2L, (byte)1, "User", 0L, 0L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Basket_UserID",
                schema: "Sales",
                table: "Basket",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItem_BasketID",
                schema: "Sales",
                table: "BasketItem",
                column: "BasketID");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItem_ProductID",
                schema: "Sales",
                table: "BasketItem",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_i18n_CategoryID",
                schema: "Catalog",
                table: "Category_i18n",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Category_i18n_LanguageID",
                schema: "Catalog",
                table: "Category_i18n",
                column: "LanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryID",
                schema: "AddressBook",
                table: "City",
                column: "CountryID");

            migrationBuilder.CreateIndex(
                name: "IX_JobExecution_JobID",
                schema: "Configuration",
                table: "JobExecution",
                column: "JobID");

            migrationBuilder.CreateIndex(
                name: "IX_JobExecutionDetail_JobExecutionID",
                schema: "Configuration",
                table: "JobExecutionDetail",
                column: "JobExecutionID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryID",
                schema: "Catalog",
                table: "Product",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_i18n_LanguageID",
                schema: "Catalog",
                table: "Product_i18n",
                column: "LanguageID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_i18n_ProductID",
                schema: "Catalog",
                table: "Product_i18n",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductComment_ProductID",
                schema: "Catalog",
                table: "ProductComment",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductComment_UserID",
                schema: "Catalog",
                table: "ProductComment",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_PermissionID",
                schema: "Membership",
                table: "RolePermission",
                column: "PermissionID");

            migrationBuilder.CreateIndex(
                name: "IX_RolePermission_RoleID",
                schema: "Membership",
                table: "RolePermission",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleID",
                schema: "Membership",
                table: "User",
                column: "RoleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AuditLog",
                schema: "Logging");

            migrationBuilder.DropTable(
                name: "BasketItem",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "Category_i18n",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "City",
                schema: "AddressBook");

            migrationBuilder.DropTable(
                name: "ExceptionLog",
                schema: "Logging");

            migrationBuilder.DropTable(
                name: "JobExecutionDetail",
                schema: "Configuration");

            migrationBuilder.DropTable(
                name: "Parameter",
                schema: "Configuration");

            migrationBuilder.DropTable(
                name: "Product_i18n",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "ProductComment",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "RolePermission",
                schema: "Membership");

            migrationBuilder.DropTable(
                name: "Basket",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "Country",
                schema: "AddressBook");

            migrationBuilder.DropTable(
                name: "JobExecution",
                schema: "Configuration");

            migrationBuilder.DropTable(
                name: "Language",
                schema: "Configuration");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Permission",
                schema: "Membership");

            migrationBuilder.DropTable(
                name: "User",
                schema: "Membership");

            migrationBuilder.DropTable(
                name: "Job",
                schema: "Configuration");

            migrationBuilder.DropTable(
                name: "Category",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "Membership");
        }
    }
}
