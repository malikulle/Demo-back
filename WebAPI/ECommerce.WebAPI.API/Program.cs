using ECommerce.Data.Persistence;
using ECommerce.Data.Service;
using ECommerce.Framework.SharedLibary.Domain.Base;
using ECommerce.Framework.SharedLibary.Extensions;
using ECommerce.Framework.SharedLibary.Middleware;
using ECommerce.Module.Integration.HangfireIntegration;
using ECommerce.Module.Wrapper;
using Hangfire;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddMemoryCache();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.Configure<Settings>(builder.Configuration.GetSection("Settings"));
builder.Services.AddPersistenceServices(builder.Configuration);
builder.Services.AddDataServices(builder.Configuration);
builder.Services.AddWrapperServices();
builder.Services.AddIntegrationHangfire(builder.Configuration);


builder.Services.AddCors(options =>
{
    options.AddPolicy("CorsPolicy",
        builder => builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder =>
{
    builder.WithOrigins("http://localhost:3000")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials();
});
app.UseCors("CorsPolicy");

app.UseMiddleware<ExceptionHandlingMiddleware>();
app.UseStaticFiles();

app.UseHangfireDashboard("/hangfire");


app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
