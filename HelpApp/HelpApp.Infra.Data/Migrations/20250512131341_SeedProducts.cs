using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HelpApp.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Name", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, 1, "Mouse óptico com iluminação RGB", "mouse.jpg", "Mouse Gamer", 89.90m, 50 },
                    { 2, 2, "Caixa de som portátil com bateria recarregável", "caixa_som.jpg", "Caixa de Som Bluetooth", 199.90m, 40 },
                    { 3, 3, "Caneca de cerâmica com estampa personalizada", "caneca.jpg", "Caneca Personalizada", 29.90m, 150 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
