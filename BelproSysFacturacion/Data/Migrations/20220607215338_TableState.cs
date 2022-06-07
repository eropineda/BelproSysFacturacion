using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BelproSysFacturacion.Data.Migrations
{
    public partial class TableState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StateModelStateISO",
                table: "CountryModels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StateModels",
                columns: table => new
                {
                    StateISO = table.Column<int>(type: "int", maxLength: 3, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateSecundaryCodeISO = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    StateDescrip = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    UserEnrollmentInsert = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EnrollmentDateInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserEnrollmentModify = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EnrollmentDateModify = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateModels", x => x.StateISO);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CountryModels_StateModelStateISO",
                table: "CountryModels",
                column: "StateModelStateISO");

            migrationBuilder.AddForeignKey(
                name: "FK_CountryModels_StateModels_StateModelStateISO",
                table: "CountryModels",
                column: "StateModelStateISO",
                principalTable: "StateModels",
                principalColumn: "StateISO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryModels_StateModels_StateModelStateISO",
                table: "CountryModels");

            migrationBuilder.DropTable(
                name: "StateModels");

            migrationBuilder.DropIndex(
                name: "IX_CountryModels_StateModelStateISO",
                table: "CountryModels");

            migrationBuilder.DropColumn(
                name: "StateModelStateISO",
                table: "CountryModels");
        }
    }
}
