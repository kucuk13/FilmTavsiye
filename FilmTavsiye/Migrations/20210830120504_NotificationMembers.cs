using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FilmTavsiye.Migrations
{
    public partial class NotificationMembers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotificationMembers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NotificationId = table.Column<int>(type: "integer", nullable: false),
                    MemberId = table.Column<int>(type: "integer", nullable: false),
                    IsRead = table.Column<bool>(type: "boolean", nullable: false),
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
                    table.PrimaryKey("PK_NotificationMembers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotificationMembers_Members_CreatedMemberId",
                        column: x => x.CreatedMemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotificationMembers_Members_DeletedMemberId",
                        column: x => x.DeletedMemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotificationMembers_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotificationMembers_Members_UpdatedMemberId",
                        column: x => x.UpdatedMemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_NotificationMembers_Notifications_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 5, 4, 363, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 5, 4, 363, DateTimeKind.Local).AddTicks(9425));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 5, 4, 363, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 5, 4, 363, DateTimeKind.Local).AddTicks(9431));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 5, 4, 363, DateTimeKind.Local).AddTicks(9433));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 5, 4, 363, DateTimeKind.Local).AddTicks(5937));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 5, 4, 363, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 5, 4, 363, DateTimeKind.Local).AddTicks(6711));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 5, 4, 363, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 5, 4, 363, DateTimeKind.Local).AddTicks(6714));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 5, 4, 363, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 5, 4, 363, DateTimeKind.Local).AddTicks(6719));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 5, 4, 363, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 5, 4, 363, DateTimeKind.Local).AddTicks(6722));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 5, 4, 363, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 5, 4, 363, DateTimeKind.Local).AddTicks(6725));

            migrationBuilder.UpdateData(
                table: "MemberRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 5, 4, 364, DateTimeKind.Local).AddTicks(943));

            migrationBuilder.UpdateData(
                table: "MemberRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 5, 4, 364, DateTimeKind.Local).AddTicks(1432));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 5, 4, 361, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 5, 4, 362, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.CreateIndex(
                name: "IX_NotificationMembers_CreatedMemberId",
                table: "NotificationMembers",
                column: "CreatedMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationMembers_DeletedMemberId",
                table: "NotificationMembers",
                column: "DeletedMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationMembers_MemberId",
                table: "NotificationMembers",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationMembers_NotificationId",
                table: "NotificationMembers",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationMembers_UpdatedMemberId",
                table: "NotificationMembers",
                column: "UpdatedMemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotificationMembers");

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

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 15, 1, 18, 880, DateTimeKind.Local).AddTicks(9459));

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
        }
    }
}
