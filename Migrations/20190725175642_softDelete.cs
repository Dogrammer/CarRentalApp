using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApp.Migrations
{
    public partial class softDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Rentals",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 886, DateTimeKind.Utc).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 886, DateTimeKind.Utc).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 886, DateTimeKind.Utc).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 886, DateTimeKind.Utc).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 886, DateTimeKind.Utc).AddTicks(783));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 884, DateTimeKind.Utc).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 884, DateTimeKind.Utc).AddTicks(5878));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 884, DateTimeKind.Utc).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 884, DateTimeKind.Utc).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 884, DateTimeKind.Utc).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 884, DateTimeKind.Utc).AddTicks(5901));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 884, DateTimeKind.Utc).AddTicks(5907));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 886, DateTimeKind.Utc).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 886, DateTimeKind.Utc).AddTicks(7558));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 886, DateTimeKind.Utc).AddTicks(7564));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 886, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 886, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 886, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 886, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 886, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 886, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 886, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 886, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 886, DateTimeKind.Utc).AddTicks(7570));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 886, DateTimeKind.Utc).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 886, DateTimeKind.Utc).AddTicks(7575));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 887, DateTimeKind.Utc).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 887, DateTimeKind.Utc).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 887, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 887, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 887, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 887, DateTimeKind.Utc).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 887, DateTimeKind.Utc).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 887, DateTimeKind.Utc).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 887, DateTimeKind.Utc).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 887, DateTimeKind.Utc).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 887, DateTimeKind.Utc).AddTicks(9943));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 887, DateTimeKind.Utc).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 887, DateTimeKind.Utc).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 887, DateTimeKind.Utc).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 887, DateTimeKind.Utc).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 887, DateTimeKind.Utc).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 888, DateTimeKind.Utc).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 888, DateTimeKind.Utc).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 888, DateTimeKind.Utc).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 888, DateTimeKind.Utc).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 888, DateTimeKind.Utc).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 888, DateTimeKind.Utc).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 17, 56, 41, 888, DateTimeKind.Utc).AddTicks(9614));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Rentals");

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 304, DateTimeKind.Utc).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 304, DateTimeKind.Utc).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 304, DateTimeKind.Utc).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 304, DateTimeKind.Utc).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 304, DateTimeKind.Utc).AddTicks(3495));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 302, DateTimeKind.Utc).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 302, DateTimeKind.Utc).AddTicks(8033));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 302, DateTimeKind.Utc).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 302, DateTimeKind.Utc).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 302, DateTimeKind.Utc).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 302, DateTimeKind.Utc).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 302, DateTimeKind.Utc).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 304, DateTimeKind.Utc).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(151));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 305, DateTimeKind.Utc).AddTicks(8172));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 306, DateTimeKind.Utc).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 306, DateTimeKind.Utc).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 306, DateTimeKind.Utc).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 306, DateTimeKind.Utc).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 306, DateTimeKind.Utc).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 306, DateTimeKind.Utc).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 306, DateTimeKind.Utc).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 307, DateTimeKind.Utc).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 307, DateTimeKind.Utc).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 307, DateTimeKind.Utc).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 307, DateTimeKind.Utc).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 307, DateTimeKind.Utc).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 307, DateTimeKind.Utc).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 15, 51, 29, 307, DateTimeKind.Utc).AddTicks(2252));
        }
    }
}
