using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FilmTavsiye.Migrations
{
    public partial class Movie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Summary = table.Column<string>(type: "text", nullable: true),
                    Year = table.Column<int>(type: "integer", nullable: false),
                    DurationInMinutes = table.Column<int>(type: "integer", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
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
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_Members_CreatedMemberId",
                        column: x => x.CreatedMemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Movies_Members_DeletedMemberId",
                        column: x => x.DeletedMemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movies_Members_UpdatedMemberId",
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
                value: new DateTime(2021, 8, 30, 14, 35, 17, 322, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 35, 17, 322, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 35, 17, 322, DateTimeKind.Local).AddTicks(646));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 35, 17, 322, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "ConstantValues",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 35, 17, 322, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 35, 17, 321, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 35, 17, 321, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 35, 17, 321, DateTimeKind.Local).AddTicks(7754));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 35, 17, 321, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 35, 17, 321, DateTimeKind.Local).AddTicks(7757));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 35, 17, 321, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 35, 17, 321, DateTimeKind.Local).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 35, 17, 321, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Constants",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 35, 17, 321, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "MemberRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 35, 17, 322, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "MemberRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 35, 17, 322, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 35, 17, 319, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 35, 17, 320, DateTimeKind.Local).AddTicks(5968));

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CreatedMemberId",
                table: "Movies",
                column: "CreatedMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_DeletedMemberId",
                table: "Movies",
                column: "DeletedMemberId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_UpdatedMemberId",
                table: "Movies",
                column: "UpdatedMemberId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");

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

            migrationBuilder.UpdateData(
                table: "MemberRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 33, 35, 403, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "MemberRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2021, 8, 30, 14, 33, 35, 403, DateTimeKind.Local).AddTicks(3049));

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
        }
    }
}
