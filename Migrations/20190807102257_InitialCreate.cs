using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Zip = table.Column<string>(maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 100, nullable: false),
                    LastName = table.Column<string>(maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    DrivingLicenceNumber = table.Column<string>(maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Brand = table.Column<string>(maxLength: 150, nullable: false),
                    Model = table.Column<string>(maxLength: 100, nullable: false),
                    ProductionYear = table.Column<int>(nullable: false),
                    Mileage = table.Column<int>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    CarCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_CarCategories_CarCategoryId",
                        column: x => x.CarCategoryId,
                        principalTable: "CarCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rentals",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    ModifiedAt = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Remarks = table.Column<string>(nullable: true),
                    PickUpLocationId = table.Column<int>(nullable: false),
                    DropOffLocationId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    CarId = table.Column<int>(nullable: false),
                    Reserved = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rentals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rentals_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rentals_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rentals_Locations_DropOffLocationId",
                        column: x => x.DropOffLocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rentals_Locations_PickUpLocationId",
                        column: x => x.PickUpLocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "CarCategories",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 8, 7, 10, 22, 56, 862, DateTimeKind.Utc).AddTicks(185), false, null, "van" },
                    { 2, new DateTime(2019, 8, 7, 10, 22, 56, 862, DateTimeKind.Utc).AddTicks(640), false, null, "mini-van" },
                    { 3, new DateTime(2019, 8, 7, 10, 22, 56, 862, DateTimeKind.Utc).AddTicks(646), false, null, "limousine" },
                    { 4, new DateTime(2019, 8, 7, 10, 22, 56, 862, DateTimeKind.Utc).AddTicks(646), false, null, "hatchback" },
                    { 5, new DateTime(2019, 8, 7, 10, 22, 56, 862, DateTimeKind.Utc).AddTicks(646), false, null, "coupe" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ModifiedAt", "Name", "Zip" },
                values: new object[,]
                {
                    { 14, new DateTime(2019, 8, 7, 10, 22, 56, 862, DateTimeKind.Utc).AddTicks(8946), false, null, "Vinkovci", "37000" },
                    { 13, new DateTime(2019, 8, 7, 10, 22, 56, 862, DateTimeKind.Utc).AddTicks(8946), false, null, "Vukovar", "32000" },
                    { 12, new DateTime(2019, 8, 7, 10, 22, 56, 862, DateTimeKind.Utc).AddTicks(8946), false, null, "Šibenik", "22000" },
                    { 11, new DateTime(2019, 8, 7, 10, 22, 56, 862, DateTimeKind.Utc).AddTicks(8946), false, null, "Trogir", "21220" },
                    { 10, new DateTime(2019, 8, 7, 10, 22, 56, 862, DateTimeKind.Utc).AddTicks(8940), false, null, "Dubrovnik", "20000" },
                    { 8, new DateTime(2019, 8, 7, 10, 22, 56, 862, DateTimeKind.Utc).AddTicks(8940), false, null, "Krapina", "49000" },
                    { 9, new DateTime(2019, 8, 7, 10, 22, 56, 862, DateTimeKind.Utc).AddTicks(8940), false, null, "Split", "21000" },
                    { 6, new DateTime(2019, 8, 7, 10, 22, 56, 862, DateTimeKind.Utc).AddTicks(8940), false, null, "Rijeka", "51000" },
                    { 5, new DateTime(2019, 8, 7, 10, 22, 56, 862, DateTimeKind.Utc).AddTicks(8940), false, null, "Slavonski Brod", "35000" },
                    { 4, new DateTime(2019, 8, 7, 10, 22, 56, 862, DateTimeKind.Utc).AddTicks(8940), false, null, "Osijek", "31000" },
                    { 3, new DateTime(2019, 8, 7, 10, 22, 56, 862, DateTimeKind.Utc).AddTicks(8934), false, null, "Velika Gorica", "10410" },
                    { 2, new DateTime(2019, 8, 7, 10, 22, 56, 862, DateTimeKind.Utc).AddTicks(8929), false, null, "Zagreb", "10000" },
                    { 1, new DateTime(2019, 8, 7, 10, 22, 56, 862, DateTimeKind.Utc).AddTicks(8212), false, null, "Sisak", "44000" },
                    { 7, new DateTime(2019, 8, 7, 10, 22, 56, 862, DateTimeKind.Utc).AddTicks(8940), false, null, "Varaždin", "42000" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "DrivingLicenceNumber", "FirstName", "IsDeleted", "LastName", "ModifiedAt" },
                values: new object[,]
                {
                    { 8, new DateTime(2019, 8, 7, 10, 22, 56, 863, DateTimeKind.Utc).AddTicks(9937), new DateTime(1990, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "12121212", "Dario", false, "Dariović", null },
                    { 1, new DateTime(2019, 8, 7, 10, 22, 56, 863, DateTimeKind.Utc).AddTicks(8293), new DateTime(1990, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "11111111", "Ivan", false, "Ivanovic", null },
                    { 2, new DateTime(2019, 8, 7, 10, 22, 56, 863, DateTimeKind.Utc).AddTicks(9875), new DateTime(1990, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "22222222", "Marko", false, "Marković", null },
                    { 3, new DateTime(2019, 8, 7, 10, 22, 56, 863, DateTimeKind.Utc).AddTicks(9892), new DateTime(1990, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "33333333", "Josip", false, "Josipović", null },
                    { 4, new DateTime(2019, 8, 7, 10, 22, 56, 863, DateTimeKind.Utc).AddTicks(9892), new DateTime(1990, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "44444444", "Pero", false, "Perić", null },
                    { 5, new DateTime(2019, 8, 7, 10, 22, 56, 863, DateTimeKind.Utc).AddTicks(9892), new DateTime(1990, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "55555555", "Matko", false, "Matković", null },
                    { 6, new DateTime(2019, 8, 7, 10, 22, 56, 863, DateTimeKind.Utc).AddTicks(9892), new DateTime(1990, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "88888888", "Ivica", false, "Ivić", null },
                    { 7, new DateTime(2019, 8, 7, 10, 22, 56, 863, DateTimeKind.Utc).AddTicks(9897), new DateTime(1990, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "99999999", "Davor", false, "Davorić", null },
                    { 9, new DateTime(2019, 8, 7, 10, 22, 56, 863, DateTimeKind.Utc).AddTicks(9943), new DateTime(1990, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "12312312", "Dorian", false, "Dorianović", null }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Brand", "CarCategoryId", "Color", "CreatedAt", "IsDeleted", "Mileage", "Model", "ModifiedAt", "ProductionYear" },
                values: new object[,]
                {
                    { 2, "BMW", 3, "Red", new DateTime(2019, 8, 7, 10, 22, 56, 860, DateTimeKind.Utc).AddTicks(1372), false, 100500, "320d", null, 2015 },
                    { 3, "Mazda", 3, "Black", new DateTime(2019, 8, 7, 10, 22, 56, 860, DateTimeKind.Utc).AddTicks(1394), false, 12500, "3", null, 2014 },
                    { 5, "Mercedes", 3, "Black", new DateTime(2019, 8, 7, 10, 22, 56, 860, DateTimeKind.Utc).AddTicks(1400), false, 150000, "c200", null, 2013 },
                    { 7, "Peugeot", 3, "Red", new DateTime(2019, 8, 7, 10, 22, 56, 860, DateTimeKind.Utc).AddTicks(1400), false, 100500, "307", null, 2015 },
                    { 1, "Audi", 4, "Black", new DateTime(2019, 8, 7, 10, 22, 56, 859, DateTimeKind.Utc).AddTicks(9233), false, 10500, "A4", null, 2018 },
                    { 4, "Audi", 4, "Blue", new DateTime(2019, 8, 7, 10, 22, 56, 860, DateTimeKind.Utc).AddTicks(1400), false, 25500, "A7", null, 2018 },
                    { 6, "Citroen", 4, "Yellow", new DateTime(2019, 8, 7, 10, 22, 56, 860, DateTimeKind.Utc).AddTicks(1400), false, 107500, "c3", null, 2010 }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CityId", "CreatedAt", "IsDeleted", "ModifiedAt", "Name" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 8, 7, 10, 22, 56, 864, DateTimeKind.Utc).AddTicks(3941), false, null, "Vukovarska 4c" },
                    { 7, 1, new DateTime(2019, 8, 7, 10, 22, 56, 864, DateTimeKind.Utc).AddTicks(4579), false, null, "Vukovarska 15c" },
                    { 2, 2, new DateTime(2019, 8, 7, 10, 22, 56, 864, DateTimeKind.Utc).AddTicks(4567), false, null, "Zagrebačka 5" },
                    { 4, 3, new DateTime(2019, 8, 7, 10, 22, 56, 864, DateTimeKind.Utc).AddTicks(4573), false, null, "Sisačka 13" },
                    { 3, 4, new DateTime(2019, 8, 7, 10, 22, 56, 864, DateTimeKind.Utc).AddTicks(4573), false, null, "Petrova 5" },
                    { 5, 7, new DateTime(2019, 8, 7, 10, 22, 56, 864, DateTimeKind.Utc).AddTicks(4573), false, null, "Slavonska 4c" },
                    { 6, 8, new DateTime(2019, 8, 7, 10, 22, 56, 864, DateTimeKind.Utc).AddTicks(4579), false, null, "Petrinjska 4c" }
                });

            migrationBuilder.InsertData(
                table: "Rentals",
                columns: new[] { "Id", "CarId", "CreatedAt", "CustomerId", "DropOffLocationId", "EndDate", "IsDeleted", "ModifiedAt", "PickUpLocationId", "Remarks", "Reserved", "StartDate" },
                values: new object[,]
                {
                    { 4, 2, new DateTime(2019, 8, 7, 10, 22, 56, 865, DateTimeKind.Utc).AddTicks(7305), 2, 2, new DateTime(2019, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1, "blah blah", true, new DateTime(2019, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 6, new DateTime(2019, 8, 7, 10, 22, 56, 865, DateTimeKind.Utc).AddTicks(7311), 2, 2, new DateTime(2019, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1, "blah blah", true, new DateTime(2019, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 5, new DateTime(2019, 8, 7, 10, 22, 56, 865, DateTimeKind.Utc).AddTicks(7311), 2, 2, new DateTime(2019, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1, "blah blah", true, new DateTime(2019, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 4, new DateTime(2019, 8, 7, 10, 22, 56, 865, DateTimeKind.Utc).AddTicks(7311), 2, 2, new DateTime(2019, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1, "blah blah", true, new DateTime(2019, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 3, new DateTime(2019, 8, 7, 10, 22, 56, 865, DateTimeKind.Utc).AddTicks(7276), 5, 4, new DateTime(2016, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1, "blah blah", true, new DateTime(2016, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, 3, new DateTime(2019, 8, 7, 10, 22, 56, 865, DateTimeKind.Utc).AddTicks(5046), 3, 3, new DateTime(2015, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 2, "blah blah", true, new DateTime(2015, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 1, new DateTime(2019, 8, 7, 10, 22, 56, 865, DateTimeKind.Utc).AddTicks(7305), 6, 3, new DateTime(2018, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), false, null, 1, "blah blah", true, new DateTime(2018, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarCategories_Name",
                table: "CarCategories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CarCategoryId",
                table: "Cars",
                column: "CarCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cities_Name",
                table: "Cities",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Cities_Zip",
                table: "Cities",
                column: "Zip",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_DrivingLicenceNumber",
                table: "Customers",
                column: "DrivingLicenceNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CityId",
                table: "Locations",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_CarId",
                table: "Rentals",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_CustomerId",
                table: "Rentals",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_DropOffLocationId",
                table: "Rentals",
                column: "DropOffLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Rentals_PickUpLocationId",
                table: "Rentals",
                column: "PickUpLocationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rentals");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "CarCategories");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
