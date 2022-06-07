using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BelproSysFacturacion.Data.Migrations
{
    public partial class TableStaterelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CountryModels_StateModels_StateModelStateISO",
                table: "CountryModels");

            migrationBuilder.DropIndex(
                name: "IX_CountryModels_StateModelStateISO",
                table: "CountryModels");

            migrationBuilder.DropColumn(
                name: "StateModelStateISO",
                table: "CountryModels");

            migrationBuilder.AddColumn<string>(
                name: "CountryModelsCountryISO",
                table: "StateModels",
                type: "nvarchar(3)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_StateModels_CountryModelsCountryISO",
                table: "StateModels",
                column: "CountryModelsCountryISO");

            migrationBuilder.AddForeignKey(
                name: "FK_StateModels_CountryModels_CountryModelsCountryISO",
                table: "StateModels",
                column: "CountryModelsCountryISO",
                principalTable: "CountryModels",
                principalColumn: "CountryISO");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StateModels_CountryModels_CountryModelsCountryISO",
                table: "StateModels");

            migrationBuilder.DropIndex(
                name: "IX_StateModels_CountryModelsCountryISO",
                table: "StateModels");

            migrationBuilder.DropColumn(
                name: "CountryModelsCountryISO",
                table: "StateModels");

            migrationBuilder.AddColumn<int>(
                name: "StateModelStateISO",
                table: "CountryModels",
                type: "int",
                nullable: true);

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
    }
}
