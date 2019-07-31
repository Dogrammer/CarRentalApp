using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApp.Migrations
{
    public partial class SoftDeletionTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 820, DateTimeKind.Utc).AddTicks(9841));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 821, DateTimeKind.Utc).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 821, DateTimeKind.Utc).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 821, DateTimeKind.Utc).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 821, DateTimeKind.Utc).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 819, DateTimeKind.Utc).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 819, DateTimeKind.Utc).AddTicks(4738));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 819, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 819, DateTimeKind.Utc).AddTicks(4760));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 819, DateTimeKind.Utc).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 819, DateTimeKind.Utc).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 819, DateTimeKind.Utc).AddTicks(4766));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 821, DateTimeKind.Utc).AddTicks(6361));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 821, DateTimeKind.Utc).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 821, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 821, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 821, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 821, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 821, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 821, DateTimeKind.Utc).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 821, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 821, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 821, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 821, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 821, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 821, DateTimeKind.Utc).AddTicks(7078));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 822, DateTimeKind.Utc).AddTicks(5304));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 822, DateTimeKind.Utc).AddTicks(6607));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 822, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 822, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 822, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 822, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 822, DateTimeKind.Utc).AddTicks(6624));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 822, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 822, DateTimeKind.Utc).AddTicks(6629));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 823, DateTimeKind.Utc).AddTicks(760));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 823, DateTimeKind.Utc).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 823, DateTimeKind.Utc).AddTicks(1334));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 823, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 823, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 823, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 823, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 824, DateTimeKind.Utc).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 824, DateTimeKind.Utc).AddTicks(3042));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 824, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 824, DateTimeKind.Utc).AddTicks(3070));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 824, DateTimeKind.Utc).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 824, DateTimeKind.Utc).AddTicks(3076));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 27, 15, 23, 59, 824, DateTimeKind.Utc).AddTicks(3076));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
