using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApp.Migrations
{
    public partial class init12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Locations",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Customers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Cities",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Cars",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "CarCategories",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 491, DateTimeKind.Utc).AddTicks(7948));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 491, DateTimeKind.Utc).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 491, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 491, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 491, DateTimeKind.Utc).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 490, DateTimeKind.Utc).AddTicks(1177));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 490, DateTimeKind.Utc).AddTicks(3140));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 490, DateTimeKind.Utc).AddTicks(3157));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 490, DateTimeKind.Utc).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 490, DateTimeKind.Utc).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 490, DateTimeKind.Utc).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 490, DateTimeKind.Utc).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 492, DateTimeKind.Utc).AddTicks(4411));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 492, DateTimeKind.Utc).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 492, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 492, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 492, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 492, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 492, DateTimeKind.Utc).AddTicks(4980));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 492, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 492, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 492, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 492, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 492, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 492, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 492, DateTimeKind.Utc).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 493, DateTimeKind.Utc).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 493, DateTimeKind.Utc).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 493, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 493, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 493, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 493, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 493, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 493, DateTimeKind.Utc).AddTicks(4184));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 493, DateTimeKind.Utc).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 493, DateTimeKind.Utc).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 493, DateTimeKind.Utc).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 493, DateTimeKind.Utc).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 493, DateTimeKind.Utc).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 493, DateTimeKind.Utc).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 493, DateTimeKind.Utc).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 493, DateTimeKind.Utc).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 494, DateTimeKind.Utc).AddTicks(8156));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 495, DateTimeKind.Utc).AddTicks(182));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 495, DateTimeKind.Utc).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 495, DateTimeKind.Utc).AddTicks(210));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 495, DateTimeKind.Utc).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 495, DateTimeKind.Utc).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 16, 23, 495, DateTimeKind.Utc).AddTicks(216));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Locations");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "CarCategories");

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
    }
}
