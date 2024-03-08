// Player.cs
namespace basketballStatsApi.Models
{
    public class Player
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public List<GameSet> GameLog { get; set; } = new List<GameSet>(); // Collection of game sets
        public int IsActive { get; set; }
    }

    public class GameSet
    {
        public int GameSetID { get; set; }
        public string? Date { get; set; }
        public string? Team { get; set; }
        public string? Opp { get; set; }
        public string? Result { get; set; }
        public string? Points { get; set; }
        public string? Rebounds { get; set; }
        public string? Assists { get; set; }
        public string? MinutesPlayed { get; set; }
        public string? FG { get; set; }
        public string? FGA { get; set; }
        public string? ThreePoint { get; set; }
        public string? ThreePointAttempt { get; set; }
        public string? FreeThrow { get; set; }
        public string? FreeThrowAttempt { get; set; }
        public string? Oreb { get; set; }
        public string? Dreb { get; set; }
        public string? Tov { get; set; }
        public string? Blk { get; set; }
        public string? Stl { get; set; }
        public string? PersonalFouls { get; set; }

    }
}
