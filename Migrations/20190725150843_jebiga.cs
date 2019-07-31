﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApp.Migrations
{
    public partial class jebiga : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CarCategories",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 7, 25, 15, 8, 43, 234, DateTimeKind.Utc).AddTicks(3222), null, "van" },
                    { 2, new DateTime(2019, 7, 25, 15, 8, 43, 234, DateTimeKind.Utc).AddTicks(3552), null, "mini-van" },
                    { 3, new DateTime(2019, 7, 25, 15, 8, 43, 234, DateTimeKind.Utc).AddTicks(3557), null, "limousine" },
                    { 4, new DateTime(2019, 7, 25, 15, 8, 43, 234, DateTimeKind.Utc).AddTicks(3557), null, "hatchback" },
                    { 5, new DateTime(2019, 7, 25, 15, 8, 43, 234, DateTimeKind.Utc).AddTicks(3557), null, "coupe" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedAt", "ModifiedAt", "Name", "Zip" },
                values: new object[,]
                {
                    { 14, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(265), null, "Vinkovci", "37000" },
                    { 13, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(265), null, "Vukovar", "32000" },
                    { 12, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(265), null, "Šibenik", "22000" },
                    { 11, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(265), null, "Trogir", "21220" },
                    { 10, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(259), null, "Dubrovnik", "20000" },
                    { 8, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(259), null, "Krapina", "49000" },
                    { 9, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(259), null, "Split", "21000" },
                    { 6, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(259), null, "Rijeka", "51000" },
                    { 5, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(259), null, "Slavonski Brod", "35000" },
                    { 4, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(259), null, "Osijek", "31000" },
                    { 3, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(259), null, "Velika Gorica", "10410" },
                    { 2, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(253), null, "Zagreb", "10000" },
                    { 1, new DateTime(2019, 7, 25, 15, 8, 43, 234, DateTimeKind.Utc).AddTicks(9673), null, "Sisak", "44000" },
                    { 7, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(259), null, "Varaždin", "42000" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "DrivingLicenceNumber", "FirstName", "LastName", "ModifiedAt" },
                values: new object[,]
                {
                    { 8, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(8280), new DateTime(1990, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "12121212", "Dario", "Dariović", null },
                    { 1, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(7046), new DateTime(1990, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "11111111", "Ivan", "Ivanovic", null },
                    { 2, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(8263), new DateTime(1990, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "22222222", "Marko", "Marković", null },
                    { 3, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(8280), new DateTime(1990, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "33333333", "Josip", "Josipović", null },
                    { 4, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(8280), new DateTime(1990, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "44444444", "Pero", "Perić", null },
                    { 5, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(8280), new DateTime(1990, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "55555555", "Matko", "Matković", null },
                    { 6, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(8280), new DateTime(1990, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "88888888", "Ivica", "Ivić", null },
                    { 7, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(8280), new DateTime(1990, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "99999999", "Davor", "Davorić", null },
                    { 9, new DateTime(2019, 7, 25, 15, 8, 43, 235, DateTimeKind.Utc).AddTicks(8286), new DateTime(1990, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "12312312", "Dorian", "Dorianović", null }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CarCategoryId", "Color", "CreatedAt", "Mileage", "Model", "ModifiedAt", "ProductionYear" },
                values: new object[,]
                {
                    { 2, "BMW", 3, "Red", new DateTime(2019, 7, 25, 15, 8, 43, 232, DateTimeKind.Utc).AddTicks(8175), 100500, "320d", null, 2015 },
                    { 3, "Mazda", 3, "Black", new DateTime(2019, 7, 25, 15, 8, 43, 232, DateTimeKind.Utc).AddTicks(8197), 12500, "3", null, 2014 },
                    { 5, "Mercedes", 3, "Black", new DateTime(2019, 7, 25, 15, 8, 43, 232, DateTimeKind.Utc).AddTicks(8197), 150000, "c200", null, 2013 },
                    { 7, "Peugeot", 3, "Red", new DateTime(2019, 7, 25, 15, 8, 43, 232, DateTimeKind.Utc).AddTicks(8203), 100500, "307", null, 2015 },
                    { 1, "Audi", 4, "Black", new DateTime(2019, 7, 25, 15, 8, 43, 232, DateTimeKind.Utc).AddTicks(6167), 10500, "A4", null, 2018 },
                    { 4, "Audi", 4, "Blue", new DateTime(2019, 7, 25, 15, 8, 43, 232, DateTimeKind.Utc).AddTicks(8197), 25500, "A7", null, 2018 },
                    { 6, "Citroen", 4, "Yellow", new DateTime(2019, 7, 25, 15, 8, 43, 232, DateTimeKind.Utc).AddTicks(8197), 107500, "c3", null, 2010 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CityId", "CreatedAt", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 7, 25, 15, 8, 43, 236, DateTimeKind.Utc).AddTicks(2342), null, "Vukovarska 4c" },
                    { 7, 1, new DateTime(2019, 7, 25, 15, 8, 43, 236, DateTimeKind.Utc).AddTicks(2928), null, "Vukovarska 15c" },
                    { 2, 2, new DateTime(2019, 7, 25, 15, 8, 43, 236, DateTimeKind.Utc).AddTicks(2922), null, "Zagrebačka 5" },
                    { 4, 3, new DateTime(2019, 7, 25, 15, 8, 43, 236, DateTimeKind.Utc).AddTicks(2928), null, "Sisačka 13" },
                    { 3, 4, new DateTime(2019, 7, 25, 15, 8, 43, 236, DateTimeKind.Utc).AddTicks(2928), null, "Petrova 5" },
                    { 5, 7, new DateTime(2019, 7, 25, 15, 8, 43, 236, DateTimeKind.Utc).AddTicks(2928), null, "Slavonska 4c" },
                    { 6, 8, new DateTime(2019, 7, 25, 15, 8, 43, 236, DateTimeKind.Utc).AddTicks(2928), null, "Petrinjska 4c" }
                });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "Id", "CarId", "CreatedAt", "CustomerId", "DropOffLocationId", "EndDate", "ModifiedAt", "PickUpLocationId", "Remarks", "Reserved", "StartDate" },
                values: new object[,]
                {
                    { 4, 2, new DateTime(2019, 7, 25, 15, 8, 43, 237, DateTimeKind.Utc).AddTicks(2628), 2, 2, new DateTime(2019, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "blah blah", true, new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 6, new DateTime(2019, 7, 25, 15, 8, 43, 237, DateTimeKind.Utc).AddTicks(2628), 2, 2, new DateTime(2019, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "blah blah", true, new DateTime(2019, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 5, new DateTime(2019, 7, 25, 15, 8, 43, 237, DateTimeKind.Utc).AddTicks(2628), 2, 2, new DateTime(2019, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "blah blah", true, new DateTime(2019, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 4, new DateTime(2019, 7, 25, 15, 8, 43, 237, DateTimeKind.Utc).AddTicks(2628), 2, 2, new DateTime(2019, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "blah blah", true, new DateTime(2019, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 3, new DateTime(2019, 7, 25, 15, 8, 43, 237, DateTimeKind.Utc).AddTicks(2593), 5, 4, new DateTime(2016, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "blah blah", true, new DateTime(2016, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 3, new DateTime(2019, 7, 25, 15, 8, 43, 237, DateTimeKind.Utc).AddTicks(688), 3, 3, new DateTime(2015, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, "blah blah", true, new DateTime(2015, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2019, 7, 25, 15, 8, 43, 237, DateTimeKind.Utc).AddTicks(2622), 6, 3, new DateTime(2018, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, "blah blah", true, new DateTime(2018, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
