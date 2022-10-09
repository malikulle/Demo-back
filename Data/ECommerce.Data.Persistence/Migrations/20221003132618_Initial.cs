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

            migrationBuilder.InsertData(
                schema: "AddressBook",
                table: "Country",
                columns: new[] { "ID", "CodeISO", "CodeISO3", "DateCreated", "DateModified", "Name", "PhoneCode", "StatusID", "UserCreatedID", "UserModifiedID" },
                values: new object[] { 1L, "TR", "TUR", new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3081), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3068), "Türkite", "90", (byte)1, 0L, 0L });

            migrationBuilder.InsertData(
                schema: "Configuration",
                table: "Language",
                columns: new[] { "ID", "CultureCode", "DateCreated", "DateModified", "IconName", "ImagePath", "IsoCode", "Name", "StatusID", "UserCreatedID", "UserModifiedID" },
                values: new object[,]
                {
                    { 1L, "tr", new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(4560), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(4560), null, null, "tr", "Türkçe", (byte)1, 0L, 0L },
                    { 2L, "en", new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(4565), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(4564), null, null, "en", "English", (byte)1, 0L, 0L }
                });

            migrationBuilder.InsertData(
                schema: "Membership",
                table: "Role",
                columns: new[] { "ID", "DateCreated", "DateModified", "Name", "StatusID", "UserCreatedID", "UserModifiedID" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3658), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3657), "Admin", (byte)1, 0L, 0L },
                    { 2L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3662), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3661), "User", (byte)1, 0L, 0L }
                });

            migrationBuilder.InsertData(
                schema: "AddressBook",
                table: "City",
                columns: new[] { "ID", "CountryID", "DateCreated", "DateModified", "Name", "PlateCode", "StatusID", "UserCreatedID", "UserModifiedID" },
                values: new object[,]
                {
                    { 1L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3259), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3259), "Adana", "01", (byte)1, 0L, 0L },
                    { 2L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3264), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3264), "Adıyaman", "02", (byte)1, 0L, 0L },
                    { 3L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3266), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3265), "Afyon", "03", (byte)1, 0L, 0L },
                    { 4L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3267), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3266), "Ağrı", "04", (byte)1, 0L, 0L },
                    { 5L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3268), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3267), "Amasya", "05", (byte)1, 0L, 0L },
                    { 6L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3272), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3271), "Ankara", "06", (byte)1, 0L, 0L },
                    { 7L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3273), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3273), "Antalya", "07", (byte)1, 0L, 0L },
                    { 8L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3274), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3274), "Artvin", "08", (byte)1, 0L, 0L },
                    { 9L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3275), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3275), "Aydın", "09", (byte)1, 0L, 0L },
                    { 10L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3277), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3277), "Balıkesir", "10", (byte)1, 0L, 0L },
                    { 11L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3278), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3278), "Bilecik", "11", (byte)1, 0L, 0L },
                    { 12L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3280), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3280), "Bingöl", "12", (byte)1, 0L, 0L },
                    { 13L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3281), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3281), "Bitlis", "13", (byte)1, 0L, 0L },
                    { 14L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3282), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3282), "Bolu", "14", (byte)1, 0L, 0L },
                    { 15L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3283), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3283), "Burdur", "15", (byte)1, 0L, 0L },
                    { 16L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3284), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3284), "Bursa", "16", (byte)1, 0L, 0L },
                    { 17L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3286), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3285), "Çanakkale", "17", (byte)1, 0L, 0L },
                    { 18L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3288), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3287), "Çankırı", "18", (byte)1, 0L, 0L },
                    { 19L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3289), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3288), "Çorum", "19", (byte)1, 0L, 0L },
                    { 20L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3290), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3290), "Denizli", "20", (byte)1, 0L, 0L },
                    { 21L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3291), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3291), "Diyarbakır", "21", (byte)1, 0L, 0L },
                    { 22L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3292), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3292), "Edirne", "22", (byte)1, 0L, 0L },
                    { 23L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3294), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3293), "Elazığ", "23", (byte)1, 0L, 0L },
                    { 24L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3296), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3295), "Erzincan", "24", (byte)1, 0L, 0L },
                    { 25L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3298), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3297), "Erzurum", "25", (byte)1, 0L, 0L },
                    { 26L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3299), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3299), "Eskişehir", "26", (byte)1, 0L, 0L },
                    { 27L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3300), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3300), "Gaziantep", "27", (byte)1, 0L, 0L },
                    { 28L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3301), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3301), "Giresun", "28", (byte)1, 0L, 0L },
                    { 29L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3303), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3302), "Gümüşhane", "29", (byte)1, 0L, 0L },
                    { 30L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3304), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3304), "Hakkari", "30", (byte)1, 0L, 0L },
                    { 31L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3305), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3305), "Hatay", "31", (byte)1, 0L, 0L },
                    { 32L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3306), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3306), "Isparta", "32", (byte)1, 0L, 0L },
                    { 33L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3308), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3307), "İçel", "33", (byte)1, 0L, 0L },
                    { 34L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3310), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3310), "İstanbul", "34", (byte)1, 0L, 0L },
                    { 35L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3311), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3311), "İzmir", "35", (byte)1, 0L, 0L },
                    { 36L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3312), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3312), "Kars", "36", (byte)1, 0L, 0L },
                    { 37L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3314), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3314), "Kastamonu", "37", (byte)1, 0L, 0L },
                    { 38L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3315), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3315), "Kayseri", "38", (byte)1, 0L, 0L },
                    { 39L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3316), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3316), "Kırklareli", "39", (byte)1, 0L, 0L },
                    { 40L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3317), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3317), "Kırşehir", "40", (byte)1, 0L, 0L },
                    { 41L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3318), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3318), "Kocaeli", "41", (byte)1, 0L, 0L },
                    { 42L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3323), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3323), "Konya", "42", (byte)1, 0L, 0L },
                    { 43L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3324), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3324), "Kütahya", "43", (byte)1, 0L, 0L },
                    { 44L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3325), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3325), "Malatya", "44", (byte)1, 0L, 0L },
                    { 45L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3328), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3327), "Manisa", "45", (byte)1, 0L, 0L },
                    { 46L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3329), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3328), "Kahramanmaraş", "46", (byte)1, 0L, 0L },
                    { 47L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3330), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3329), "Mardin", "47", (byte)1, 0L, 0L },
                    { 48L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3331), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3330), "Muğla", "48", (byte)1, 0L, 0L },
                    { 49L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3332), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3331), "Muş", "49", (byte)1, 0L, 0L },
                    { 50L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3379), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3378), "Nevşehir", "50", (byte)1, 0L, 0L },
                    { 51L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3381), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3380), "Niğde", "51", (byte)1, 0L, 0L },
                    { 52L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3382), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3381), "Ordu", "52", (byte)1, 0L, 0L },
                    { 53L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3383), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3383), "Rize", "53", (byte)1, 0L, 0L },
                    { 54L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3384), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3384), "Sakarya", "54", (byte)1, 0L, 0L },
                    { 55L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3386), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3385), "Samsun", "55", (byte)1, 0L, 0L },
                    { 56L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3387), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3386), "Siirt", "56", (byte)1, 0L, 0L },
                    { 57L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3388), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3387), "Sinop", "57", (byte)1, 0L, 0L },
                    { 58L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3389), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3388), "Sivas", "58", (byte)1, 0L, 0L },
                    { 59L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3390), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3390), "Tekirdağ", "59", (byte)1, 0L, 0L },
                    { 60L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3391), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3391), "Tokat", "60", (byte)1, 0L, 0L },
                    { 61L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3392), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3392), "Trabzon", "61", (byte)1, 0L, 0L },
                    { 62L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3393), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3393), "Tunceli", "62", (byte)1, 0L, 0L },
                    { 63L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3394), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3394), "Şanlıurfa", "63", (byte)1, 0L, 0L },
                    { 64L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3395), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3395), "Uşak", "64", (byte)1, 0L, 0L },
                    { 65L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3396), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3396), "Van", "65", (byte)1, 0L, 0L },
                    { 66L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3398), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3398), "Yozgat", "66", (byte)1, 0L, 0L },
                    { 67L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3400), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3399), "Zonguldak", "67", (byte)1, 0L, 0L },
                    { 68L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3401), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3400), "Aksaray", "68", (byte)1, 0L, 0L },
                    { 69L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3406), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3405), "Bayburt", "69", (byte)1, 0L, 0L },
                    { 70L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3407), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3407), "Karaman", "70", (byte)1, 0L, 0L },
                    { 71L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3408), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3408), "Kırıkkale", "71", (byte)1, 0L, 0L },
                    { 72L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3410), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3410), "Batman", "72", (byte)1, 0L, 0L },
                    { 73L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3411), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3411), "Şırnak", "73", (byte)1, 0L, 0L },
                    { 74L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3412), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3412), "Bartın", "74", (byte)1, 0L, 0L },
                    { 75L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3414), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3413), "Ardahan", "75", (byte)1, 0L, 0L },
                    { 76L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3415), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3414), "Iğdır", "76", (byte)1, 0L, 0L },
                    { 77L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3416), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3415), "Yalova", "77", (byte)1, 0L, 0L },
                    { 78L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3417), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3416), "Karabük", "78", (byte)1, 0L, 0L },
                    { 79L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3418), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3417), "Kilis", "79", (byte)1, 0L, 0L },
                    { 80L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3419), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3418), "Osmaniye", "80", (byte)1, 0L, 0L },
                    { 81L, 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3421), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3420), "Düzce", "81", (byte)1, 0L, 0L }
                });

            migrationBuilder.InsertData(
                schema: "Membership",
                table: "User",
                columns: new[] { "ID", "DateCreated", "DateModified", "EmailAddress", "FullName", "ImagePath", "IsGlobalAdmin", "Name", "PasswordHash", "PasswordSalt", "RoleID", "StatusID", "Surname", "UserCreatedID", "UserModifiedID" },
                values: new object[,]
                {
                    { 1L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(4511), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(4510), "admin@admin.com", "Admin Admin", null, true, "Admin", new byte[] { 140, 94, 198, 196, 43, 211, 67, 202, 63, 22, 161, 91, 106, 117, 168, 197, 67, 211, 226, 17, 80, 228, 97, 253, 7, 179, 6, 41, 181, 156, 253, 78, 42, 142, 124, 227, 118, 83, 219, 143, 11, 179, 247, 7, 86, 0, 25, 63, 28, 133, 107, 31, 97, 225, 61, 98, 203, 220, 42, 153, 45, 153, 166, 21 }, new byte[] { 227, 11, 226, 81, 195, 203, 112, 155, 120, 222, 174, 180, 111, 36, 120, 11, 28, 7, 109, 143, 165, 113, 87, 127, 200, 43, 92, 142, 52, 12, 61, 44, 226, 247, 141, 221, 134, 158, 251, 103, 28, 19, 178, 85, 43, 220, 96, 243, 220, 61, 154, 125, 5, 59, 178, 35, 242, 133, 166, 198, 34, 230, 8, 183, 245, 118, 174, 119, 98, 141, 21, 33, 239, 100, 143, 132, 230, 31, 253, 38, 59, 156, 88, 61, 82, 109, 42, 165, 112, 110, 19, 238, 94, 15, 201, 216, 163, 37, 245, 177, 190, 130, 213, 5, 127, 255, 48, 56, 195, 48, 194, 157, 0, 211, 24, 187, 150, 61, 227, 22, 164, 148, 85, 180, 164, 113, 255, 108 }, 1L, (byte)1, "Admin", 0L, 0L },
                    { 2L, new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(4521), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(4520), "user@user.com", "User User", null, false, "User", new byte[] { 140, 94, 198, 196, 43, 211, 67, 202, 63, 22, 161, 91, 106, 117, 168, 197, 67, 211, 226, 17, 80, 228, 97, 253, 7, 179, 6, 41, 181, 156, 253, 78, 42, 142, 124, 227, 118, 83, 219, 143, 11, 179, 247, 7, 86, 0, 25, 63, 28, 133, 107, 31, 97, 225, 61, 98, 203, 220, 42, 153, 45, 153, 166, 21 }, new byte[] { 227, 11, 226, 81, 195, 203, 112, 155, 120, 222, 174, 180, 111, 36, 120, 11, 28, 7, 109, 143, 165, 113, 87, 127, 200, 43, 92, 142, 52, 12, 61, 44, 226, 247, 141, 221, 134, 158, 251, 103, 28, 19, 178, 85, 43, 220, 96, 243, 220, 61, 154, 125, 5, 59, 178, 35, 242, 133, 166, 198, 34, 230, 8, 183, 245, 118, 174, 119, 98, 141, 21, 33, 239, 100, 143, 132, 230, 31, 253, 38, 59, 156, 88, 61, 82, 109, 42, 165, 112, 110, 19, 238, 94, 15, 201, 216, 163, 37, 245, 177, 190, 130, 213, 5, 127, 255, 48, 56, 195, 48, 194, 157, 0, 211, 24, 187, 150, 61, 227, 22, 164, 148, 85, 180, 164, 113, 255, 108 }, 2L, (byte)1, "User", 0L, 0L }
                });

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
                name: "IX_Product_CategoryID",
                schema: "Catalog",
                table: "Product",
                column: "CategoryID");

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
                name: "Category_i18n",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "City",
                schema: "AddressBook");

            migrationBuilder.DropTable(
                name: "ExceptionLog",
                schema: "Logging");

            migrationBuilder.DropTable(
                name: "Parameter",
                schema: "Configuration");

            migrationBuilder.DropTable(
                name: "Product",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "RolePermission",
                schema: "Membership");

            migrationBuilder.DropTable(
                name: "User",
                schema: "Membership");

            migrationBuilder.DropTable(
                name: "Language",
                schema: "Configuration");

            migrationBuilder.DropTable(
                name: "Country",
                schema: "AddressBook");

            migrationBuilder.DropTable(
                name: "Category",
                schema: "Catalog");

            migrationBuilder.DropTable(
                name: "Permission",
                schema: "Membership");

            migrationBuilder.DropTable(
                name: "Role",
                schema: "Membership");
        }
    }
}
