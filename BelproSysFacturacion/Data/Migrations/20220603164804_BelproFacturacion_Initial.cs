using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BelproSysFacturacion.Data.Migrations
{
    public partial class BelproFacturacion_Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CountyModels",
                columns: table => new
                {
                    IdCounty = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountyDescrip = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserEnrollmentInsert = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EnrollmentDateInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserEnrollmentModify = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EnrollmentDateModify = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountyModels", x => x.IdCounty);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountyModels");
        }
    }
}
