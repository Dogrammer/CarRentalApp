using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApp.Migrations
{
    public partial class jebiga7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Rentals",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Locations",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Customers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Cities",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Cars",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "CarCategories",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 984, DateTimeKind.Utc).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 984, DateTimeKind.Utc).AddTicks(1142));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 984, DateTimeKind.Utc).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 984, DateTimeKind.Utc).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 984, DateTimeKind.Utc).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 982, DateTimeKind.Utc).AddTicks(4348));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 982, DateTimeKind.Utc).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 982, DateTimeKind.Utc).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 982, DateTimeKind.Utc).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 982, DateTimeKind.Utc).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 982, DateTimeKind.Utc).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 982, DateTimeKind.Utc).AddTicks(6254));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 984, DateTimeKind.Utc).AddTicks(7190));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 984, DateTimeKind.Utc).AddTicks(7827));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 984, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 984, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 984, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 984, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 984, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 984, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 984, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 984, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 984, DateTimeKind.Utc).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 984, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 984, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 984, DateTimeKind.Utc).AddTicks(7844));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 985, DateTimeKind.Utc).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 985, DateTimeKind.Utc).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 985, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 985, DateTimeKind.Utc).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 985, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 985, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 985, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 985, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 985, DateTimeKind.Utc).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 986, DateTimeKind.Utc).AddTicks(934));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 986, DateTimeKind.Utc).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 986, DateTimeKind.Utc).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 986, DateTimeKind.Utc).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 986, DateTimeKind.Utc).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 986, DateTimeKind.Utc).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 986, DateTimeKind.Utc).AddTicks(1497));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 987, DateTimeKind.Utc).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 987, DateTimeKind.Utc).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 987, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 987, DateTimeKind.Utc).AddTicks(2875));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 987, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 987, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 11, 32, 43, 987, DateTimeKind.Utc).AddTicks(2881));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Rentals");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "CarCategories");

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 13, DateTimeKind.Utc).AddTicks(4074));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 13, DateTimeKind.Utc).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 13, DateTimeKind.Utc).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 13, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 13, DateTimeKind.Utc).AddTicks(4416));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 11, DateTimeKind.Utc).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 11, DateTimeKind.Utc).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 11, DateTimeKind.Utc).AddTicks(9533));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 11, DateTimeKind.Utc).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 11, DateTimeKind.Utc).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 11, DateTimeKind.Utc).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 11, DateTimeKind.Utc).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 14, DateTimeKind.Utc).AddTicks(434));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 14, DateTimeKind.Utc).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 14, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 14, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 14, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 14, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 14, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 14, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 14, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 14, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 14, DateTimeKind.Utc).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 14, DateTimeKind.Utc).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 14, DateTimeKind.Utc).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 14, DateTimeKind.Utc).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 14, DateTimeKind.Utc).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 15, DateTimeKind.Utc).AddTicks(242));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 15, DateTimeKind.Utc).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 15, DateTimeKind.Utc).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 15, DateTimeKind.Utc).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 15, DateTimeKind.Utc).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 15, DateTimeKind.Utc).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 15, DateTimeKind.Utc).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 15, DateTimeKind.Utc).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 15, DateTimeKind.Utc).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 15, DateTimeKind.Utc).AddTicks(4709));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 15, DateTimeKind.Utc).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 15, DateTimeKind.Utc).AddTicks(4714));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 15, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 15, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 15, DateTimeKind.Utc).AddTicks(4720));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 16, DateTimeKind.Utc).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 16, DateTimeKind.Utc).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 16, DateTimeKind.Utc).AddTicks(6342));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 16, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 16, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 16, DateTimeKind.Utc).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 26, 7, 16, 31, 16, DateTimeKind.Utc).AddTicks(6348));
        }
    }
}
