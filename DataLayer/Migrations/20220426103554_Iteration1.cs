using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataLayer.Migrations
{
    public partial class Iteration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StorageArea",
                columns: table => new
                {
                    StorageAreaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    INN = table.Column<int>(type: "int", nullable: false),
                    KPP = table.Column<int>(type: "int", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Area = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StorageArea", x => x.StorageAreaId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false),
                    HasFullRights = table.Column<bool>(type: "bit", nullable: false),
                    IsEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Detail",
                columns: table => new
                {
                    DetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DetailNumber = table.Column<int>(type: "int", nullable: false),
                    ManufactYear = table.Column<int>(type: "int", nullable: false),
                    ManufactCode = table.Column<int>(type: "int", nullable: false),
                    InDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RailCar = table.Column<int>(type: "int", nullable: false),
                    StorageSq = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    WheelSize = table.Column<int>(type: "int", nullable: false),
                    DetailCategory = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DetailCondition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachedFiles = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StorageAreaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detail", x => x.DetailId);
                    table.ForeignKey(
                        name: "FK_Detail_StorageArea_StorageAreaId",
                        column: x => x.StorageAreaId,
                        principalTable: "StorageArea",
                        principalColumn: "StorageAreaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detail_StorageAreaId",
                table: "Detail",
                column: "StorageAreaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detail");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "StorageArea");
        }
    }
}
