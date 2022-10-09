using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ECommerce.Data.Persistence.Migrations
{
    public partial class ProductComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 4L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 5L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 6L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 7L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 8L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 9L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 10L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 11L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 12L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 13L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 14L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 15L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 16L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 17L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 18L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 19L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 20L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 21L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 22L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 23L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 24L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 25L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 26L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 27L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 28L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 29L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 30L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 31L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 32L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 33L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 34L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 35L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 36L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 37L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 38L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 39L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 40L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 41L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 42L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 43L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 44L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 45L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 46L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 47L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 48L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 49L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 50L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 51L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 52L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 53L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 54L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 55L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 56L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 57L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 58L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 59L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 60L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 61L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 62L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 63L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 64L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 65L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 66L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 67L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 68L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 69L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 70L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 71L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 72L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 73L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 74L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 75L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 76L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 77L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 78L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 79L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 80L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 81L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "Country",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "Configuration",
                table: "Language",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "Configuration",
                table: "Language",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "Membership",
                table: "Role",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "Membership",
                table: "Role",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                schema: "Membership",
                table: "User",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateModified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 4, 28, 10, 173, 157, 244, 19, 166, 52, 81, 90, 107, 46, 58, 11, 212, 228, 151, 161, 70, 65, 145, 146, 221, 10, 242, 62, 140, 23, 144, 122, 146, 205, 14, 180, 196, 155, 232, 24, 104, 211, 158, 148, 119, 139, 51, 246, 27, 186, 7, 152, 187, 120, 189, 1, 14, 119, 255, 65, 21, 16, 120, 160, 225 }, new byte[] { 171, 83, 100, 84, 95, 73, 239, 131, 236, 132, 218, 66, 96, 144, 69, 241, 55, 135, 10, 141, 132, 107, 176, 239, 9, 119, 32, 112, 172, 184, 163, 133, 177, 57, 122, 161, 22, 191, 154, 49, 149, 215, 66, 252, 251, 97, 132, 197, 81, 17, 155, 95, 40, 242, 41, 148, 204, 188, 25, 218, 69, 238, 78, 28, 168, 209, 160, 6, 139, 213, 162, 107, 184, 242, 198, 202, 34, 242, 203, 173, 240, 233, 49, 33, 1, 6, 193, 22, 214, 22, 136, 72, 150, 12, 230, 249, 130, 186, 252, 113, 23, 110, 10, 76, 230, 132, 217, 100, 125, 202, 135, 86, 186, 211, 25, 246, 191, 193, 29, 65, 17, 165, 233, 46, 92, 220, 28, 124 } });

            migrationBuilder.UpdateData(
                schema: "Membership",
                table: "User",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateModified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new byte[] { 4, 28, 10, 173, 157, 244, 19, 166, 52, 81, 90, 107, 46, 58, 11, 212, 228, 151, 161, 70, 65, 145, 146, 221, 10, 242, 62, 140, 23, 144, 122, 146, 205, 14, 180, 196, 155, 232, 24, 104, 211, 158, 148, 119, 139, 51, 246, 27, 186, 7, 152, 187, 120, 189, 1, 14, 119, 255, 65, 21, 16, 120, 160, 225 }, new byte[] { 171, 83, 100, 84, 95, 73, 239, 131, 236, 132, 218, 66, 96, 144, 69, 241, 55, 135, 10, 141, 132, 107, 176, 239, 9, 119, 32, 112, 172, 184, 163, 133, 177, 57, 122, 161, 22, 191, 154, 49, 149, 215, 66, 252, 251, 97, 132, 197, 81, 17, 155, 95, 40, 242, 41, 148, 204, 188, 25, 218, 69, 238, 78, 28, 168, 209, 160, 6, 139, 213, 162, 107, 184, 242, 198, 202, 34, 242, 203, 173, 240, 233, 49, 33, 1, 6, 193, 22, 214, 22, 136, 72, 150, 12, 230, 249, 130, 186, 252, 113, 23, 110, 10, 76, 230, 132, 217, 100, 125, 202, 135, 86, 186, 211, 25, 246, 191, 193, 29, 65, 17, 165, 233, 46, 92, 220, 28, 124 } });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductComment",
                schema: "Catalog");

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2352), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2352) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2356), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2356) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 3L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2358), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 4L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2359), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 5L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2360), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2360) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 6L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2363), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2363) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 7L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2365), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2364) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 8L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2366), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2365) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 9L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2367), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2366) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 10L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2369), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2368) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 11L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2370), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2369) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 12L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2372), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2371) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 13L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2373), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2372) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 14L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2374), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2373) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 15L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2375), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 16L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2376), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2376) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 17L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2378), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2378) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 18L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2380), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2380) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 19L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2381), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2381) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 20L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2382), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2382) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 21L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2383), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2383) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 22L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2384), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2384) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 23L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2386), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2386) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 24L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2388), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2387) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 25L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2390), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2389) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 26L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2391), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2390) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 27L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2392), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2391) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 28L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2393), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 29L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2394), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2394) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 30L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2395), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2395) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 31L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2396), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 32L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2398), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 33L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2399), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 34L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2401), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 35L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2402), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 36L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2403), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 37L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2405), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2404) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 38L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2406), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 39L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2407), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2407) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 40L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2408), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2408) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 41L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2452), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 42L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2454), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 43L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2455), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2455) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 44L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2456), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2456) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 45L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2457), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 46L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2459), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2458) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 47L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2460), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2459) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 48L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2461), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2460) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 49L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2462), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2461) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 50L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2463), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2462) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 51L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2464), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 52L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2465), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2465) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 53L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2466), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2466) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 54L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2467), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2467) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 55L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2468), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2468) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 56L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2469), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2469) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 57L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2471), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2470) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 58L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2472), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2471) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 59L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2473), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 60L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2474), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 61L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2475), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2474) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 62L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2476), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 63L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2477), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2477) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 64L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2478), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 65L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2479), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 66L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2482), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 67L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2483), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 68L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2484), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2483) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 69L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2485), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2484) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 70L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2486), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 71L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2487), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2487) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 72L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2488), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2488) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 73L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2489), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2489) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 74L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2490), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 75L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2492), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2491) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 76L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2493), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2492) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 77L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2494), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 78L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2495), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2494) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 79L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2496), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 80L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2497), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2497) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "City",
                keyColumn: "ID",
                keyValue: 81L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2498), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2498) });

            migrationBuilder.UpdateData(
                schema: "AddressBook",
                table: "Country",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2264), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.UpdateData(
                schema: "Configuration",
                table: "Language",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(3095), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(3095) });

            migrationBuilder.UpdateData(
                schema: "Configuration",
                table: "Language",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(3099), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(3099) });

            migrationBuilder.UpdateData(
                schema: "Membership",
                table: "Role",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2704), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2703) });

            migrationBuilder.UpdateData(
                schema: "Membership",
                table: "Role",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateModified" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2708), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(2707) });

            migrationBuilder.UpdateData(
                schema: "Membership",
                table: "User",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "DateCreated", "DateModified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(3059), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(3058), new byte[] { 200, 9, 188, 200, 52, 166, 170, 108, 230, 20, 116, 120, 114, 75, 31, 219, 175, 166, 30, 90, 61, 45, 193, 90, 167, 211, 11, 167, 32, 164, 7, 131, 107, 84, 21, 5, 1, 149, 208, 180, 50, 2, 146, 175, 219, 134, 25, 189, 84, 114, 173, 197, 77, 9, 103, 203, 224, 36, 243, 2, 161, 80, 178, 141 }, new byte[] { 36, 151, 123, 184, 134, 245, 186, 147, 226, 7, 167, 166, 114, 36, 201, 245, 98, 124, 43, 160, 151, 96, 205, 93, 0, 178, 252, 192, 233, 149, 233, 20, 233, 87, 148, 144, 237, 72, 167, 130, 148, 251, 101, 216, 242, 63, 180, 199, 53, 248, 70, 29, 80, 182, 226, 74, 116, 145, 214, 208, 43, 58, 24, 211, 45, 140, 218, 164, 12, 224, 37, 246, 17, 174, 100, 255, 181, 150, 254, 164, 200, 111, 212, 201, 151, 59, 26, 158, 135, 6, 138, 31, 174, 207, 56, 54, 225, 56, 33, 97, 34, 102, 104, 150, 95, 221, 112, 215, 255, 171, 233, 123, 127, 107, 93, 230, 56, 204, 15, 148, 146, 161, 5, 239, 191, 68, 38, 150 } });

            migrationBuilder.UpdateData(
                schema: "Membership",
                table: "User",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "DateCreated", "DateModified", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(3066), new DateTime(2022, 10, 5, 21, 14, 18, 428, DateTimeKind.Local).AddTicks(3066), new byte[] { 200, 9, 188, 200, 52, 166, 170, 108, 230, 20, 116, 120, 114, 75, 31, 219, 175, 166, 30, 90, 61, 45, 193, 90, 167, 211, 11, 167, 32, 164, 7, 131, 107, 84, 21, 5, 1, 149, 208, 180, 50, 2, 146, 175, 219, 134, 25, 189, 84, 114, 173, 197, 77, 9, 103, 203, 224, 36, 243, 2, 161, 80, 178, 141 }, new byte[] { 36, 151, 123, 184, 134, 245, 186, 147, 226, 7, 167, 166, 114, 36, 201, 245, 98, 124, 43, 160, 151, 96, 205, 93, 0, 178, 252, 192, 233, 149, 233, 20, 233, 87, 148, 144, 237, 72, 167, 130, 148, 251, 101, 216, 242, 63, 180, 199, 53, 248, 70, 29, 80, 182, 226, 74, 116, 145, 214, 208, 43, 58, 24, 211, 45, 140, 218, 164, 12, 224, 37, 246, 17, 174, 100, 255, 181, 150, 254, 164, 200, 111, 212, 201, 151, 59, 26, 158, 135, 6, 138, 31, 174, 207, 56, 54, 225, 56, 33, 97, 34, 102, 104, 150, 95, 221, 112, 215, 255, 171, 233, 123, 127, 107, 93, 230, 56, 204, 15, 148, 146, 161, 5, 239, 191, 68, 38, 150 } });
        }
    }
}
