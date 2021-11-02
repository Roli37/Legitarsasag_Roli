using Microsoft.EntityFrameworkCore.Migrations;

namespace Legitarsasag_Roli.Migrations
{
    public partial class LegitarsasagMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Airlines",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Airlines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Population = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Flights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Airline = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CityFrom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityTo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Distance = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    Duration = table.Column<int>(type: "int", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flights", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Airlines",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Wizz Air" },
                    { 22, "Lufthansa" },
                    { 21, "Lufthansa" },
                    { 20, "Lufthansa" },
                    { 19, "Lufthansa" },
                    { 18, "Lufthansa" },
                    { 17, "Lufthansa" },
                    { 16, "Lufthansa" },
                    { 15, "Lufthansa" },
                    { 14, "Lufthansa" },
                    { 12, "British Airways" },
                    { 13, "British Airways" },
                    { 10, "British Airways" },
                    { 9, "British Airways" },
                    { 8, "British Airways" },
                    { 7, "Wizz Air" },
                    { 6, "Wizz Air" },
                    { 5, "Wizz Air" },
                    { 4, "Wizz Air" },
                    { 3, "Wizz Air" },
                    { 2, "Wizz Air" },
                    { 11, "British Airways" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "Population" },
                values: new object[,]
                {
                    { 6, "Roma", 2900000 },
                    { 7, "Washington", 2700000 },
                    { 5, "New York", 8500000 },
                    { 4, "Madrid", 3100000 },
                    { 3, "Los Angeles", 13800000 },
                    { 2, "London", 8800000 },
                    { 1, "Budapest", 1800000 }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "Airline", "CityFrom", "CityTo", "Distance", "Duration" },
                values: new object[,]
                {
                    { 20, "Lufthansa", "Washington", "New York", 475, 55 },
                    { 19, "Lufthansa", "New York", "Washington", 475, 55 },
                    { 18, "Lufthansa", "Madrid", "Washington", 6090, 470 },
                    { 17, "Lufthansa", "London", "Washington", 5900, 480 },
                    { 16, "Lufthansa", "London", "New York", 5510, 485 },
                    { 15, "Lufthansa", "Budapest", "Madrid", 1975, 210 },
                    { 14, "Lufthansa", "Budapest", "London", 1450, 150 },
                    { 13, "British Airways", "Washington", "Los Angeles", 3695, 340 },
                    { 12, "British Airways", "Washington", "New York", 475, 55 },
                    { 11, "British Airways", "New York", "Washington", 475, 55 },
                    { 10, "British Airways", "London", "New York", 5510, 470 },
                    { 9, "British Airways", "Budapest", "Madrid", 1975, 205 },
                    { 8, "British Airways", "Budapest", "London", 1450, 155 }
                });

            migrationBuilder.InsertData(
                table: "Flights",
                columns: new[] { "Id", "Airline", "CityFrom", "CityTo", "Distance", "Duration" },
                values: new object[,]
                {
                    { 7, "Wizz Air", "Madrid", "London", 1265, 190 },
                    { 6, "Wizz Air", "London", "Madrid", 1265, 190 },
                    { 5, "Wizz Air", "Roma", "Madrid", 1365, 205 },
                    { 4, "Wizz Air", "Roma", "London", 1435, 210 },
                    { 3, "Wizz Air", "Budapest", "Madrid", 1975, 195 },
                    { 2, "Wizz Air", "Budapest", "Roma", 810, 105 },
                    { 1, "Wizz Air", "Budapest", "London", 1450, 145 },
                    { 21, "Lufthansa", "New York", "Los Angeles", 3805, 350 },
                    { 22, "Lufthansa", "Washington", "Los Angeles", 3695, 340 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Airlines");

            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Flights");
        }
    }
}
