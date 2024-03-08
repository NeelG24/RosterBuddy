using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace basketballStatsApi.Migrations
{
    /// <inheritdoc />
    public partial class FullGameLogsAddedWithDates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Date",
                table: "GameSets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Opp",
                table: "GameSets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Result",
                table: "GameSets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Team",
                table: "GameSets",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "GameSets");

            migrationBuilder.DropColumn(
                name: "Opp",
                table: "GameSets");

            migrationBuilder.DropColumn(
                name: "Result",
                table: "GameSets");

            migrationBuilder.DropColumn(
                name: "Team",
                table: "GameSets");
        }
    }
}
