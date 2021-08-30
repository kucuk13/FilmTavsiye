using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FilmTavsiye.Migrations
{
    public partial class ConstantValue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ConstantValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    ConstantId = table.Column<int>(type: "integer", nullable: false),
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
                    table.PrimaryKey("PK_ConstantValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ConstantValues_Constants_ConstantId",
                        column: x => x.ConstantId,
                        principalTable: "Constants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConstantValues_Members_CreatedMemberId",
                        column: x => x.CreatedMemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConstantValues_Members_DeletedMemberId",
                        column: x => x.DeletedMemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConstantValues_Members_UpdatedMemberId",
                        column: x => x.UpdatedMemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ConstantValues",
                columns: new[] { "Id", "ConstantId", "CreatedDateTime", "CreatedMemberId", "DeletedDateTime", "DeletedMemberId", "Name", "Status", "UpdatedDateTime", "UpdatedMemberId" },
                values: new object[,]
                {
                    { 1, 2, new DateTime(2021, 8, 30, 14, 27, 31, 61, DateTimeKind.Local).AddTicks(3335), 1, null, null, "Active", 1, null, null },
                    { 2, 2, new DateTime(2021, 8, 30, 14, 27, 31, 61, DateTimeKind.Local).AddTicks(3970), 1, null, null, "Passive", 1, null, null },
                    { 3, 2, new DateTime(2021, 8, 30, 14, 27, 31, 61, DateTimeKind.Local).AddTicks(3975), 1, null, null, "Deleted", 1, null, null },
                    { 4, 1, new DateTime(2021, 8, 30, 14, 27, 31, 61, DateTimeKind.Local).AddTicks(3977), 1, null, null, "Admin", 1, null, null },
                    { 5, 1, new DateTime(2021, 8, 30, 14, 27, 31, 61, DateTimeKind.Local).AddTicks(3978), 1, null, null, "Editor", 1, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 27, 31, 61, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 27, 31, 61, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 27, 31, 61, DateTimeKind.Local).AddTicks(1108));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 27, 31, 61, DateTimeKind.Local).AddTicks(1110));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 27, 31, 61, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 27, 31, 61, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 27, 31, 61, DateTimeKind.Local).AddTicks(1116));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 27, 31, 61, DateTimeKind.Local).AddTicks(1117));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 27, 31, 61, DateTimeKind.Local).AddTicks(1118));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 27, 31, 58, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 27, 31, 59, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.CreateIndex(
                name: "IX_ConstantValues_ConstantId",
                table: "ConstantValues",
                column: "ConstantId");

            migrationBuilder.CreateIndex(
                name: "IX_ConstantValues_CreatedMemberId",
                table: "ConstantValues",
                column: "CreatedMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_ConstantValues_DeletedMemberId",
                table: "ConstantValues",
                column: "DeletedMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_ConstantValues_UpdatedMemberId",
                table: "ConstantValues",
                column: "UpdatedMemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConstantValues");

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1220));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1227));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1228));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 19, 0, 679, DateTimeKind.Local).AddTicks(1235));

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
        }
    }
}
