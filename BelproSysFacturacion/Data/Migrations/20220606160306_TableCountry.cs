using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BelproSysFacturacion.Data.Migrations
{
    public partial class TableCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CountryModels",
                columns: table => new
                {
                    CountryISO = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    UserEnrollmentInsert = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EnrollmentDateInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserEnrollmentModify = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EnrollmentDateModify = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryModels", x => x.CountryISO);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountryModels");
        }
    }
}
