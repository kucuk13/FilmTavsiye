using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FilmTavsiye.Migrations
{
    public partial class Notification : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    TypeId = table.Column<int>(type: "integer", nullable: true),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    DueDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Url = table.Column<string>(type: "text", nullable: true),
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
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_ConstantValues_TypeId",
                        column: x => x.TypeId,
                        principalTable: "ConstantValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notifications_Members_CreatedMemberId",
                        column: x => x.CreatedMemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notifications_Members_DeletedMemberId",
                        column: x => x.DeletedMemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Notifications_Members_UpdatedMemberId",
                        column: x => x.UpdatedMemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 1, 18, 881, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 1, 18, 881, DateTimeKind.Local).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 1, 18, 881, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 1, 18, 881, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 1, 18, 881, DateTimeKind.Local).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9440));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9447));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9449));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9452));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9455));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9456));

            migrationBuilder.InsertData(
                table: "Constants",
                columns: new[] { "Id", "CreatedDateTime", "CreatedMemberId", "DeletedDateTime", "DeletedMemberId", "Name", "Status", "UpdatedDateTime", "UpdatedMemberId" },
                values: new object[,]
                {
                    { 10, new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9458), 1, null, null, "Menu Type", 1, null, null },
                    { 11, new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9459), 1, null, null, "Notification Type", 1, null, null }
                });

            migrationBuilder.UpdateData(
                table: "MemberRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 1, 18, 881, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "MemberRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 1, 18, 881, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 1, 18, 878, DateTimeKind.Local).AddTicks(7268));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 1, 18, 879, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_CreatedMemberId",
                table: "Notifications",
                column: "CreatedMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_DeletedMemberId",
                table: "Notifications",
                column: "DeletedMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_TypeId",
                table: "Notifications",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UpdatedMemberId",
                table: "Notifications",
                column: "UpdatedMemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DeleteData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 50, 37, 42, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 50, 37, 42, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 50, 37, 42, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 50, 37, 42, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 50, 37, 42, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 50, 37, 42, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 50, 37, 42, DateTimeKind.Local).AddTicks(4960));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 50, 37, 42, DateTimeKind.Local).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 50, 37, 42, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 50, 37, 42, DateTimeKind.Local).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 50, 37, 42, DateTimeKind.Local).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 50, 37, 42, DateTimeKind.Local).AddTicks(5020));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 50, 37, 42, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 50, 37, 42, DateTimeKind.Local).AddTicks(5023));

            migrationBuilder.UpdateData(
                table: "MemberRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 50, 37, 42, DateTimeKind.Local).AddTicks(9503));

            migrationBuilder.UpdateData(
                table: "MemberRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 50, 37, 43, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 50, 37, 40, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 50, 37, 41, DateTimeKind.Local).AddTicks(3142));
        }
    }
}
