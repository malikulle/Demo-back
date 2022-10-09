using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ECommerce.Data.Persistence.Migrations
{
    public partial class Basket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Sales");

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

            migrationBuilder.UpdateData(
                schema: "Membership",
                table: "User",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 1, 84, 112, 73, 48, 5, 186, 68, 133, 38, 47, 183, 10, 224, 121, 244, 242, 35, 53, 208, 200, 73, 81, 91, 214, 157, 238, 18, 64, 17, 232, 119, 210, 70, 76, 88, 38, 240, 179, 135, 67, 48, 10, 248, 121, 126, 24, 58, 74, 178, 202, 9, 231, 5, 179, 196, 105, 167, 218, 40, 179, 242, 201, 112 }, new byte[] { 151, 239, 8, 107, 246, 88, 129, 231, 78, 133, 212, 40, 5, 250, 19, 109, 101, 170, 104, 99, 6, 234, 28, 47, 44, 223, 43, 234, 46, 186, 139, 226, 101, 92, 22, 69, 0, 84, 165, 204, 31, 32, 246, 53, 222, 160, 193, 179, 201, 46, 160, 188, 92, 179, 113, 137, 122, 21, 88, 19, 251, 224, 34, 248, 10, 28, 195, 19, 183, 205, 1, 190, 87, 232, 223, 141, 217, 118, 104, 14, 36, 98, 100, 5, 192, 246, 83, 57, 122, 120, 212, 124, 182, 173, 249, 126, 191, 64, 227, 141, 244, 208, 47, 203, 48, 125, 226, 17, 59, 13, 202, 145, 182, 197, 136, 116, 16, 193, 56, 227, 207, 44, 229, 121, 213, 140, 60, 146 } });

            migrationBuilder.UpdateData(
                schema: "Membership",
                table: "User",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 1, 84, 112, 73, 48, 5, 186, 68, 133, 38, 47, 183, 10, 224, 121, 244, 242, 35, 53, 208, 200, 73, 81, 91, 214, 157, 238, 18, 64, 17, 232, 119, 210, 70, 76, 88, 38, 240, 179, 135, 67, 48, 10, 248, 121, 126, 24, 58, 74, 178, 202, 9, 231, 5, 179, 196, 105, 167, 218, 40, 179, 242, 201, 112 }, new byte[] { 151, 239, 8, 107, 246, 88, 129, 231, 78, 133, 212, 40, 5, 250, 19, 109, 101, 170, 104, 99, 6, 234, 28, 47, 44, 223, 43, 234, 46, 186, 139, 226, 101, 92, 22, 69, 0, 84, 165, 204, 31, 32, 246, 53, 222, 160, 193, 179, 201, 46, 160, 188, 92, 179, 113, 137, 122, 21, 88, 19, 251, 224, 34, 248, 10, 28, 195, 19, 183, 205, 1, 190, 87, 232, 223, 141, 217, 118, 104, 14, 36, 98, 100, 5, 192, 246, 83, 57, 122, 120, 212, 124, 182, 173, 249, 126, 191, 64, 227, 141, 244, 208, 47, 203, 48, 125, 226, 17, 59, 13, 202, 145, 182, 197, 136, 116, 16, 193, 56, 227, 207, 44, 229, 121, 213, 140, 60, 146 } });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketItem",
                schema: "Sales");

            migrationBuilder.DropTable(
                name: "Basket",
                schema: "Sales");

            migrationBuilder.UpdateData(
                schema: "Membership",
                table: "User",
                keyColumn: "ID",
                keyValue: 1L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 4, 28, 10, 173, 157, 244, 19, 166, 52, 81, 90, 107, 46, 58, 11, 212, 228, 151, 161, 70, 65, 145, 146, 221, 10, 242, 62, 140, 23, 144, 122, 146, 205, 14, 180, 196, 155, 232, 24, 104, 211, 158, 148, 119, 139, 51, 246, 27, 186, 7, 152, 187, 120, 189, 1, 14, 119, 255, 65, 21, 16, 120, 160, 225 }, new byte[] { 171, 83, 100, 84, 95, 73, 239, 131, 236, 132, 218, 66, 96, 144, 69, 241, 55, 135, 10, 141, 132, 107, 176, 239, 9, 119, 32, 112, 172, 184, 163, 133, 177, 57, 122, 161, 22, 191, 154, 49, 149, 215, 66, 252, 251, 97, 132, 197, 81, 17, 155, 95, 40, 242, 41, 148, 204, 188, 25, 218, 69, 238, 78, 28, 168, 209, 160, 6, 139, 213, 162, 107, 184, 242, 198, 202, 34, 242, 203, 173, 240, 233, 49, 33, 1, 6, 193, 22, 214, 22, 136, 72, 150, 12, 230, 249, 130, 186, 252, 113, 23, 110, 10, 76, 230, 132, 217, 100, 125, 202, 135, 86, 186, 211, 25, 246, 191, 193, 29, 65, 17, 165, 233, 46, 92, 220, 28, 124 } });

            migrationBuilder.UpdateData(
                schema: "Membership",
                table: "User",
                keyColumn: "ID",
                keyValue: 2L,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 4, 28, 10, 173, 157, 244, 19, 166, 52, 81, 90, 107, 46, 58, 11, 212, 228, 151, 161, 70, 65, 145, 146, 221, 10, 242, 62, 140, 23, 144, 122, 146, 205, 14, 180, 196, 155, 232, 24, 104, 211, 158, 148, 119, 139, 51, 246, 27, 186, 7, 152, 187, 120, 189, 1, 14, 119, 255, 65, 21, 16, 120, 160, 225 }, new byte[] { 171, 83, 100, 84, 95, 73, 239, 131, 236, 132, 218, 66, 96, 144, 69, 241, 55, 135, 10, 141, 132, 107, 176, 239, 9, 119, 32, 112, 172, 184, 163, 133, 177, 57, 122, 161, 22, 191, 154, 49, 149, 215, 66, 252, 251, 97, 132, 197, 81, 17, 155, 95, 40, 242, 41, 148, 204, 188, 25, 218, 69, 238, 78, 28, 168, 209, 160, 6, 139, 213, 162, 107, 184, 242, 198, 202, 34, 242, 203, 173, 240, 233, 49, 33, 1, 6, 193, 22, 214, 22, 136, 72, 150, 12, 230, 249, 130, 186, 252, 113, 23, 110, 10, 76, 230, 132, 217, 100, 125, 202, 135, 86, 186, 211, 25, 246, 191, 193, 29, 65, 17, 165, 233, 46, 92, 220, 28, 124 } });
        }
    }
}
