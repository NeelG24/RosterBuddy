using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace basketballStatsApi.Migrations
{
    /// <inheritdoc />
    public partial class BackToNoramal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameLogs");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "GameLogs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Assists = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlayerID = table.Column<int>(type: "int", nullable: false),
                    Points = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rebounds = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameLogs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_GameLogs_Players_PlayerID",
                        column: x => x.PlayerID,
                        principalTable: "Players",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GameLogs_PlayerID",
                table: "GameLogs",
                column: "PlayerID");
        }
    }
}
