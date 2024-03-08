using Microsoft.EntityFrameworkCore;

// PlayerContext.cs
namespace basketballStatsApi.Models
{
    public class PlayerContext : DbContext
    {
        public PlayerContext(DbContextOptions<PlayerContext> options) : base(options)
        {
        }
        public DbSet<Player> Players { get; set; }
        public DbSet<GameSet> GameSets { get; set; } // Add DbSet for GameSet
    }
}

