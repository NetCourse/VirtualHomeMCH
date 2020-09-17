using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleApp1.Migrations
{
    public partial class InitialModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AirConditioners",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    model = table.Column<string>(nullable: true),
                    temperature = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AirConditioners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Laptops",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TVs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TVs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DoorLocks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true),
                    isOn = table.Column<bool>(nullable: false),
                    locationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoorLocks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DoorLocks_Rooms_locationId",
                        column: x => x.locationId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Lights",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    color = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    isOn = table.Column<bool>(nullable: false),
                    locationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lights_Rooms_locationId",
                        column: x => x.locationId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoorLocks_locationId",
                table: "DoorLocks",
                column: "locationId");

            migrationBuilder.CreateIndex(
                name: "IX_Lights_locationId",
                table: "Lights",
                column: "locationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AirConditioners");

            migrationBuilder.DropTable(
                name: "DoorLocks");

            migrationBuilder.DropTable(
                name: "Laptops");

            migrationBuilder.DropTable(
                name: "Lights");

            migrationBuilder.DropTable(
                name: "TVs");

            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
