using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotellerieMariem.Migrations
{
    /// <inheritdoc />
    public partial class AddPaysHotel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pays",
                table: "Hotels",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Tunisie"); // <-- Ajout de la valeur par défaut "Tunisie"
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pays",
                table: "Hotels");
        }
    }
}