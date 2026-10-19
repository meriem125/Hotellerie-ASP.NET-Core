using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotellerieMariem.Migrations
{
    public partial class ajoutAppreciation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appreciations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomPers = table.Column<string>(nullable: false),
                    Commentaire = table.Column<string>(nullable: false),
                    Note = table.Column<int>(nullable: false, defaultValue: 3),
                    HotelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appreciations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appreciations_Hotels_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appreciations_HotelId",
                table: "Appreciations",
                column: "HotelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appreciations");
        }
    }
}