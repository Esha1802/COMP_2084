using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace COMP_2084_Assigment_1.Data.Migrations
{
    public partial class PropertyTablesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BuildingType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnitType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnitType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProvinceState",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvinceState", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProvinceState_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AddressLine2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PostalZipCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ProvinceStateId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_ProvinceState_ProvinceStateId",
                        column: x => x.ProvinceStateId,
                        principalTable: "ProvinceState",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Properties",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LandlordId = table.Column<int>(type: "int", nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    BuildingTypeId = table.Column<int>(type: "int", nullable: false),
                    UnitTypeId = table.Column<int>(type: "int", nullable: false),
                    ProvinceStateId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Properties", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Properties_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_BuildingType_BuildingTypeId",
                        column: x => x.BuildingTypeId,
                        principalTable: "BuildingType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Properties_Landlords_LandlordId",
                        column: x => x.LandlordId,
                        principalTable: "Landlords",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Properties_ProvinceState_ProvinceStateId",
                        column: x => x.ProvinceStateId,
                        principalTable: "ProvinceState",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Properties_UnitType_UnitTypeId",
                        column: x => x.UnitTypeId,
                        principalTable: "UnitType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ProvinceStateId",
                table: "Addresses",
                column: "ProvinceStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_AddressId",
                table: "Properties",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Properties_BuildingTypeId",
                table: "Properties",
                column: "BuildingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_LandlordId",
                table: "Properties",
                column: "LandlordId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_ProvinceStateId",
                table: "Properties",
                column: "ProvinceStateId");

            migrationBuilder.CreateIndex(
                name: "IX_Properties_UnitTypeId",
                table: "Properties",
                column: "UnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ProvinceState_CountryId",
                table: "ProvinceState",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Properties");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "BuildingType");

            migrationBuilder.DropTable(
                name: "UnitType");

            migrationBuilder.DropTable(
                name: "ProvinceState");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
