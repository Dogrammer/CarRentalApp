using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApp.Migrations
{
    public partial class AddedSoftDeleteFunctionallity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 552, DateTimeKind.Utc).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 552, DateTimeKind.Utc).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 552, DateTimeKind.Utc).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 552, DateTimeKind.Utc).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "CarCategories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 552, DateTimeKind.Utc).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 550, DateTimeKind.Utc).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 550, DateTimeKind.Utc).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 550, DateTimeKind.Utc).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 550, DateTimeKind.Utc).AddTicks(7675));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 550, DateTimeKind.Utc).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 550, DateTimeKind.Utc).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 550, DateTimeKind.Utc).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 552, DateTimeKind.Utc).AddTicks(8519));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 552, DateTimeKind.Utc).AddTicks(9168));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 552, DateTimeKind.Utc).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 552, DateTimeKind.Utc).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 552, DateTimeKind.Utc).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 552, DateTimeKind.Utc).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 552, DateTimeKind.Utc).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 552, DateTimeKind.Utc).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 552, DateTimeKind.Utc).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 552, DateTimeKind.Utc).AddTicks(9247));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 552, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 552, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 552, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 552, DateTimeKind.Utc).AddTicks(9253));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 553, DateTimeKind.Utc).AddTicks(5858));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 553, DateTimeKind.Utc).AddTicks(7024));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 553, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 553, DateTimeKind.Utc).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 553, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 553, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 553, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 553, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 553, DateTimeKind.Utc).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 554, DateTimeKind.Utc).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 554, DateTimeKind.Utc).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 554, DateTimeKind.Utc).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 554, DateTimeKind.Utc).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 554, DateTimeKind.Utc).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 554, DateTimeKind.Utc).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 554, DateTimeKind.Utc).AddTicks(1405));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 554, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 555, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 555, DateTimeKind.Utc).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 555, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 555, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 555, DateTimeKind.Utc).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "Rentals",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2019, 7, 25, 18, 51, 0, 555, DateTimeKind.Utc).AddTicks(808));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
