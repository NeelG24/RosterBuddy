using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace basketballStatsApi.Migrations
{
    /// <inheritdoc />
    public partial class FullGameLogsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Blk",
                table: "GameSets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Dreb",
                table: "GameSets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FG",
                table: "GameSets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FGA",
                table: "GameSets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FreeThrow",
                table: "GameSets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FreeThrowAttempt",
                table: "GameSets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MinutesPlayed",
                table: "GameSets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Oreb",
                table: "GameSets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonalFouls",
                table: "GameSets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Stl",
                table: "GameSets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThreePoint",
                table: "GameSets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThreePointAttempt",
                table: "GameSets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tov",
                table: "GameSets",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Blk",
                table: "GameSets");

            migrationBuilder.DropColumn(
                name: "Dreb",
                table: "GameSets");

            migrationBuilder.DropColumn(
                name: "FG",
                table: "GameSets");

            migrationBuilder.DropColumn(
                name: "FGA",
                table: "GameSets");

            migrationBuilder.DropColumn(
                name: "FreeThrow",
                table: "GameSets");

            migrationBuilder.DropColumn(
                name: "FreeThrowAttempt",
                table: "GameSets");

            migrationBuilder.DropColumn(
                name: "MinutesPlayed",
                table: "GameSets");

            migrationBuilder.DropColumn(
                name: "Oreb",
                table: "GameSets");

            migrationBuilder.DropColumn(
                name: "PersonalFouls",
                table: "GameSets");

            migrationBuilder.DropColumn(
                name: "Stl",
                table: "GameSets");

            migrationBuilder.DropColumn(
                name: "ThreePoint",
                table: "GameSets");

            migrationBuilder.DropColumn(
                name: "ThreePointAttempt",
                table: "GameSets");

            migrationBuilder.DropColumn(
                name: "Tov",
                table: "GameSets");
        }
    }
}
