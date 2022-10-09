using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ECommerce.Data.Persistence.Migrations
{
    public partial class Product : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                schema: "Catalog",
                table: "Product",
                type: "text",
                nullable: true);

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

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6090), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6090) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6097), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6097) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6098), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6098) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 4L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6100), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6099) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 5L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6101), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6100) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 6L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6105), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6104) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 7L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6106), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6106) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 8L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6107), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6107) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 9L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6108), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6108) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 10L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6110), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6110) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 11L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6111), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6111) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 12L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6113), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6112) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 13L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6114), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6113) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 14L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6115), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6114) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 15L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6116), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6115) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 16L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6117), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6117) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 17L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6119), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 18L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6120), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6120) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 19L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6122), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6122) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 20L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6124), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6123) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 21L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6125), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6124) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 22L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6126), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6126) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 23L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6127), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6127) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 24L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6128), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6128) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 25L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6129), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6129) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 26L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6130), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6130) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 27L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6132), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6131) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 28L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6134), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6133) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 29L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6135), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6134) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 30L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6136), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6135) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 31L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6137), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6137) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 32L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6138), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6138) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 33L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6139), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6139) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 34L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6141), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6141) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 35L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6142), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6142) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 36L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6143), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6143) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 37L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6144), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 38L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6187), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6186) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 39L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6188), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6188) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 40L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6189), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6189) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 41L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6191), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6190) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 42L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6192), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6191) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 43L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6193), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6192) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 44L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6194), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6194) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 45L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6195), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6195) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 46L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6196), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6196) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 47L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6197), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6197) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 48L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6198), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6198) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 49L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6200), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6200) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 50L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6201), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6201) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 51L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6203), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6202) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 52L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6204), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6204) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 53L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6205), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6205) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 54L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6206), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6206) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 55L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6207), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6207) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 56L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6208), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6208) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 57L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6209), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6209) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 58L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6210), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 59L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6211), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6211) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 60L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6212), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6212) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 61L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6214), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6213) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 62L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6215), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6214) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 63L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6216), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6215) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 64L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6217), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6216) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 65L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6218), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6218) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 66L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6220), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6219) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 67L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6221), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6220) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 68L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6222), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6222) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 69L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6223), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6223) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 70L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6224), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 71L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6225), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6225) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 72L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6226), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6226) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 73L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6227), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6227) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 74L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6228), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6228) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 75L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6229), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6229) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 76L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6230), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6230) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 77L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6231), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6231) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 78L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6233), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6232) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 79L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6234), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6233) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 80L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6235), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6234) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 81L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6236), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "Country",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(5967), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                schema: "Configuration",
                table: "Language",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(7241), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                schema: "Configuration",
                table: "Language",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(7246), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(7246) });

            migrationBuilder.UpdateData(
                schema: "Membership",
                table: "Role",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6422), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6421) });

            migrationBuilder.UpdateData(
                schema: "Membership",
                table: "Role",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6427), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(6426) });

            migrationBuilder.UpdateData(
                schema: "Membership",
                table: "User",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateModified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(7193), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(7192), new byte[] { 145, 49, 123, 243, 98, 71, 81, 127, 215, 99, 106, 225, 74, 152, 123, 243, 93, 98, 103, 56, 151, 145, 118, 191, 26, 109, 61, 170, 85, 162, 136, 60, 215, 66, 203, 29, 9, 248, 178, 208, 89, 130, 101, 75, 91, 75, 62, 207, 246, 11, 164, 33, 53, 50, 232, 246, 58, 49, 85, 52, 10, 119, 116, 53 }, new byte[] { 254, 200, 25, 135, 87, 49, 11, 32, 212, 29, 141, 164, 219, 94, 18, 53, 124, 141, 28, 10, 57, 223, 222, 230, 118, 12, 0, 84, 250, 44, 5, 8, 130, 134, 115, 218, 70, 216, 239, 12, 194, 110, 176, 126, 187, 221, 156, 123, 175, 105, 102, 207, 113, 147, 229, 247, 242, 74, 192, 50, 179, 124, 56, 225, 157, 126, 45, 105, 27, 49, 187, 222, 79, 120, 150, 144, 207, 73, 113, 85, 220, 246, 131, 78, 61, 88, 93, 83, 31, 253, 105, 45, 183, 119, 68, 157, 120, 69, 135, 130, 246, 39, 179, 86, 234, 220, 34, 99, 229, 71, 26, 71, 13, 144, 241, 82, 3, 181, 34, 166, 30, 146, 235, 15, 24, 200, 208, 247 } });

            migrationBuilder.UpdateData(
                schema: "Membership",
                table: "User",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateModified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(7202), new DateTime(2022, 10, 3, 18, 11, 55, 603, DateTimeKind.Local).AddTicks(7201), new byte[] { 145, 49, 123, 243, 98, 71, 81, 127, 215, 99, 106, 225, 74, 152, 123, 243, 93, 98, 103, 56, 151, 145, 118, 191, 26, 109, 61, 170, 85, 162, 136, 60, 215, 66, 203, 29, 9, 248, 178, 208, 89, 130, 101, 75, 91, 75, 62, 207, 246, 11, 164, 33, 53, 50, 232, 246, 58, 49, 85, 52, 10, 119, 116, 53 }, new byte[] { 254, 200, 25, 135, 87, 49, 11, 32, 212, 29, 141, 164, 219, 94, 18, 53, 124, 141, 28, 10, 57, 223, 222, 230, 118, 12, 0, 84, 250, 44, 5, 8, 130, 134, 115, 218, 70, 216, 239, 12, 194, 110, 176, 126, 187, 221, 156, 123, 175, 105, 102, 207, 113, 147, 229, 247, 242, 74, 192, 50, 179, 124, 56, 225, 157, 126, 45, 105, 27, 49, 187, 222, 79, 120, 150, 144, 207, 73, 113, 85, 220, 246, 131, 78, 61, 88, 93, 83, 31, 253, 105, 45, 183, 119, 68, 157, 120, 69, 135, 130, 246, 39, 179, 86, 234, 220, 34, 99, 229, 71, 26, 71, 13, 144, 241, 82, 3, 181, 34, 166, 30, 146, 235, 15, 24, 200, 208, 247 } });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product_i18n",
                schema: "Catalog");

            migrationBuilder.DropColumn(
                name: "Description",
                schema: "Catalog",
                table: "Product");

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3259), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3259) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3264), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3264) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3266), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3265) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 4L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3267), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3266) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 5L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3268), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3267) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 6L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3272), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3271) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 7L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3273), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3273) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 8L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3274), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3274) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 9L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3275), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 10L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3277), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3277) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 11L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3278), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3278) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 12L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3280), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 13L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3281), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3281) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 14L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3282), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3282) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 15L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3283), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3283) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 16L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3284), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3284) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 17L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3286), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3285) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 18L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3288), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3287) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 19L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3289), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3288) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 20L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3290), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3290) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 21L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3291), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3291) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 22L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3292), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 23L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3294), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3293) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 24L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3296), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3295) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 25L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3298), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3297) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 26L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3299), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3299) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 27L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3300), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3300) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 28L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3301), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3301) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 29L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3303), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3302) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 30L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3304), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3304) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 31L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3305), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3305) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 32L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3306), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 33L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3308), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 34L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3310), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3310) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 35L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3311), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 36L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3312), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3312) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 37L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3314), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3314) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 38L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3315), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3315) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 39L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3316), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3316) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 40L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3317), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3317) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 41L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3318), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 42L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3323), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3323) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 43L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3324), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3324) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 44L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3325), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3325) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 45L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3328), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3327) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 46L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3329), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3328) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 47L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3330), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3329) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 48L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3331), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3330) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 49L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3332), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 50L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3379), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3378) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 51L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3381), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3380) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 52L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3382), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3381) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 53L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3383), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3383) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 54L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3384), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3384) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 55L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3386), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3385) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 56L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3387), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3386) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 57L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3388), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3387) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 58L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3389), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3388) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 59L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3390), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3390) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 60L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3391), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3391) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 61L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3392), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3392) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 62L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3393), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3393) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 63L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3394), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3394) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 64L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3395), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3395) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 65L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3396), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3396) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 66L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3398), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3398) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 67L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3400), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3399) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 68L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3401), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3400) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 69L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3406), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 70L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3407), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3407) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 71L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3408), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3408) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 72L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3410), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3410) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 73L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3411), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3411) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 74L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3412), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 75L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3414), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3413) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 76L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3415), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3414) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 77L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3416), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 78L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3417), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3416) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 79L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3418), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3417) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 80L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3419), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3418) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 81L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3421), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3420) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "Country",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3081), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3068) });

            migrationBuilder.UpdateData(
                schema: "Configuration",
                table: "Language",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(4560), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(4560) });

            migrationBuilder.UpdateData(
                schema: "Configuration",
                table: "Language",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(4565), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(4564) });

            migrationBuilder.UpdateData(
                schema: "Membership",
                table: "Role",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3658), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3657) });

            migrationBuilder.UpdateData(
                schema: "Membership",
                table: "Role",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3662), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(3661) });

            migrationBuilder.UpdateData(
                schema: "Membership",
                table: "User",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateModified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(4511), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(4510), new byte[] { 140, 94, 198, 196, 43, 211, 67, 202, 63, 22, 161, 91, 106, 117, 168, 197, 67, 211, 226, 17, 80, 228, 97, 253, 7, 179, 6, 41, 181, 156, 253, 78, 42, 142, 124, 227, 118, 83, 219, 143, 11, 179, 247, 7, 86, 0, 25, 63, 28, 133, 107, 31, 97, 225, 61, 98, 203, 220, 42, 153, 45, 153, 166, 21 }, new byte[] { 227, 11, 226, 81, 195, 203, 112, 155, 120, 222, 174, 180, 111, 36, 120, 11, 28, 7, 109, 143, 165, 113, 87, 127, 200, 43, 92, 142, 52, 12, 61, 44, 226, 247, 141, 221, 134, 158, 251, 103, 28, 19, 178, 85, 43, 220, 96, 243, 220, 61, 154, 125, 5, 59, 178, 35, 242, 133, 166, 198, 34, 230, 8, 183, 245, 118, 174, 119, 98, 141, 21, 33, 239, 100, 143, 132, 230, 31, 253, 38, 59, 156, 88, 61, 82, 109, 42, 165, 112, 110, 19, 238, 94, 15, 201, 216, 163, 37, 245, 177, 190, 130, 213, 5, 127, 255, 48, 56, 195, 48, 194, 157, 0, 211, 24, 187, 150, 61, 227, 22, 164, 148, 85, 180, 164, 113, 255, 108 } });

            migrationBuilder.UpdateData(
                schema: "Membership",
                table: "User",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateModified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(4521), new DateTime(2022, 10, 3, 16, 26, 18, 359, DateTimeKind.Local).AddTicks(4520), new byte[] { 140, 94, 198, 196, 43, 211, 67, 202, 63, 22, 161, 91, 106, 117, 168, 197, 67, 211, 226, 17, 80, 228, 97, 253, 7, 179, 6, 41, 181, 156, 253, 78, 42, 142, 124, 227, 118, 83, 219, 143, 11, 179, 247, 7, 86, 0, 25, 63, 28, 133, 107, 31, 97, 225, 61, 98, 203, 220, 42, 153, 45, 153, 166, 21 }, new byte[] { 227, 11, 226, 81, 195, 203, 112, 155, 120, 222, 174, 180, 111, 36, 120, 11, 28, 7, 109, 143, 165, 113, 87, 127, 200, 43, 92, 142, 52, 12, 61, 44, 226, 247, 141, 221, 134, 158, 251, 103, 28, 19, 178, 85, 43, 220, 96, 243, 220, 61, 154, 125, 5, 59, 178, 35, 242, 133, 166, 198, 34, 230, 8, 183, 245, 118, 174, 119, 98, 141, 21, 33, 239, 100, 143, 132, 230, 31, 253, 38, 59, 156, 88, 61, 82, 109, 42, 165, 112, 110, 19, 238, 94, 15, 201, 216, 163, 37, 245, 177, 190, 130, 213, 5, 127, 255, 48, 56, 195, 48, 194, 157, 0, 211, 24, 187, 150, 61, 227, 22, 164, 148, 85, 180, 164, 113, 255, 108 } });
        }
    }
}
