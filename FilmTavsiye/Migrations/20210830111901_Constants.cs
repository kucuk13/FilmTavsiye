using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FilmTavsiye.Migrations
{
    public partial class Constants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Constants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    CreatedDateTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    CreatedMemberId = table.Column<int>(type: "integer", nullable: false),
                    UpdatedDateTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    UpdatedMemberId = table.Column<int>(type: "integer", nullable: true),
                    DeletedDateTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DeletedMemberId = table.Column<int>(type: "integer", nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Constants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Constants_Members_CreatedMemberId",
                        column: x => x.CreatedMemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Constants_Members_DeletedMemberId",
                        column: x => x.DeletedMemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Constants_Members_UpdatedMemberId",
                        column: x => x.UpdatedMemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Constants",
                columns: new[] { "Id", "CreatedDateTime", "CreatedMemberId", "DeletedDateTime", "DeletedMemberId", "Name", "Status", "UpdatedDateTime", "UpdatedMemberId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(465), 1, null, null, "System Roles", 1, null, null },
                    { 2, new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1220), 1, null, null, "Status", 1, null, null },
                    { 3, new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1225), 1, null, null, "Task", 1, null, null },
                    { 4, new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1227), 1, null, null, "Movie Type", 1, null, null },
                    { 5, new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1228), 1, null, null, "Country", 1, null, null },
                    { 6, new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1231), 1, null, null, "Media Type", 1, null, null },
                    { 7, new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1232), 1, null, null, "Photo Type", 1, null, null },
                    { 8, new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1234), 1, null, null, "Video Type", 1, null, null },
                    { 9, new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1235), 1, null, null, "Pegi", 1, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 19, 0, 676, DateTimeKind.Local).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 19, 0, 677, DateTimeKind.Local).AddTicks(7768));

            migrationBuilder.CreateIndex(
                name: "IX_Constants_CreatedMemberId",
                table: "Constants",
                column: "CreatedMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Constants_DeletedMemberId",
                table: "Constants",
                column: "DeletedMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Constants_UpdatedMemberId",
                table: "Constants",
                column: "UpdatedMemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Constants");

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 7, 50, 870, DateTimeKind.Local).AddTicks(1136));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 7, 50, 871, DateTimeKind.Local).AddTicks(932));
        }
    }
}
