using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FilmTavsiye.Migrations
{
    public partial class MemberRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MemberRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MemberId = table.Column<int>(type: "integer", nullable: false),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
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
                    table.PrimaryKey("PK_MemberRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberRoles_ConstantValues_RoleId",
                        column: x => x.RoleId,
                        principalTable: "ConstantValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberRoles_Members_CreatedMemberId",
                        column: x => x.CreatedMemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberRoles_Members_DeletedMemberId",
                        column: x => x.DeletedMemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MemberRoles_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MemberRoles_Members_UpdatedMemberId",
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
                value: new DateTime(2021, 8, 30, 14, 33, 35, 402, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 33, 35, 403, DateTimeKind.Local).AddTicks(290));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 33, 35, 403, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 33, 35, 403, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 33, 35, 403, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 33, 35, 402, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 33, 35, 402, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 33, 35, 402, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 33, 35, 402, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 33, 35, 402, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 33, 35, 402, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 33, 35, 402, DateTimeKind.Local).AddTicks(5407));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 33, 35, 402, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 33, 35, 402, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.InsertData(
                table: "MemberRoles",
                columns: new[] { "Id", "CreatedDateTime", "CreatedMemberId", "DeletedDateTime", "DeletedMemberId", "MemberId", "RoleId", "Status", "UpdatedDateTime", "UpdatedMemberId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 8, 30, 14, 33, 35, 403, DateTimeKind.Local).AddTicks(2225), 1, null, null, 1, 4, 1, null, null },
                    { 2, new DateTime(2021, 8, 30, 14, 33, 35, 403, DateTimeKind.Local).AddTicks(3049), 1, null, null, 2, 5, 1, null, null }
                });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 33, 35, 400, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 33, 35, 401, DateTimeKind.Local).AddTicks(3926));

            migrationBuilder.CreateIndex(
                name: "IX_MemberRoles_CreatedMemberId",
                table: "MemberRoles",
                column: "CreatedMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberRoles_DeletedMemberId",
                table: "MemberRoles",
                column: "DeletedMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberRoles_MemberId",
                table: "MemberRoles",
                column: "MemberId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberRoles_RoleId",
                table: "MemberRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_MemberRoles_UpdatedMemberId",
                table: "MemberRoles",
                column: "UpdatedMemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberRoles");

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 27, 31, 61, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 27, 31, 61, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 27, 31, 61, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 27, 31, 61, DateTimeKind.Local).AddTicks(3977));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 27, 31, 61, DateTimeKind.Local).AddTicks(3978));

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
        }
    }
}
