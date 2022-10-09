using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ECommerce.Data.Persistence.Migrations
{
    public partial class Job : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "JobExecutionDetail",
                schema: "Configuration");

            migrationBuilder.DropTable(
                name: "JobExecution",
                schema: "Configuration");

            migrationBuilder.DropTable(
                name: "Job",
                schema: "Configuration");

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
        }
    }
}
