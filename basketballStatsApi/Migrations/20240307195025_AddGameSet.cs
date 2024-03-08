using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace basketballStatsApi.Migrations
{
    /// <inheritdoc />
    public partial class AddGameSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Assists",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "Rebounds",
                table: "Players");

            migrationBuilder.CreateTable(
                name: "GameSets",
                columns: table => new
                {
                    GameSetID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Points = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rebounds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Assists = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameSets", x => x.GameSetID);
                    table.ForeignKey(
                        name: "FK_GameSets_Players_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Players",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameSets_PlayerID",
                table: "GameSets",
                column: "PlayerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameSets");

            migrationBuilder.AddColumn<string>(
                name: "Assists",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Points",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Rebounds",
                table: "Players",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
