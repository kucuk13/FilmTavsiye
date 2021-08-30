using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmTavsiye.Migrations
{
    public partial class UpdateMemberAndConstantValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Members",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelephoneNumber",
                table: "Members",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "ConstantValues",
                type: "integer",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "TelephoneNumber",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "ConstantValues");

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
        }
    }
}
