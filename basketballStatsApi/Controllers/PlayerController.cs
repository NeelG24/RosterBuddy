using basketballStatsApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

//Go back to OG migration for OG app
namespace basketballStatsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly PlayerContext _playerContext;

        // Constructor to inject PlayerContext dependency
        public PlayerController(PlayerContext playerContext)
        {
            _playerContext = playerContext;
        }

        // GET request to retrieve all players
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Player>>> GetPlayers()
        {
            if (_playerContext.Players == null)
            {
                return NotFound(); // Return 404 if players are not found
            }
            return await _playerContext.Players.ToListAsync(); // Retrieve and return all players
        }

        // GET request to retrieve a single player by ID
        [HttpGet("{id}")]
        public async Task<ActionResult<Player>> GetPlayer(int id)
        {
            if (_playerContext.Players == null)
            {
                return NotFound(); // Return 404 if players are not found
            }

            //var player = await _playerContext.Players.FindAsync(id);
            var player = await _playerContext.Players.Include(p => p.GameLog).FirstOrDefaultAsync(p => p.ID == id);
            if (player == null)
            {
                return NotFound(); // Return 404 if the specified player is not found
            }

            return player; // Return the found player
        }

        // POST request to add a new player
        [HttpPost]
        public async Task<ActionResult<Player>> PostPlayer(Player player)
        {

            _playerContext.Players.Add(player); // Add the new player to the context
            await _playerContext.SaveChangesAsync(); // Save changes to the database

            // Return a 201 Created status with the newly created player's details
            return CreatedAtAction(nameof(GetPlayer), new { id = player.ID }, player);
        }

        // PUT request to update an existing player by ID
        [HttpPut("{id}")]
        public async Task<ActionResult> PutPlayer(int id, Player player)
        {
            if (id != player.ID)
            {
                return BadRequest(); // Return 400 Bad Request if the provided ID doesn't match player.ID
            }

            _playerContext.Entry(player).State = EntityState.Modified; // Mark player as modified
            try
            {
                await _playerContext.SaveChangesAsync(); // Save changes to the database
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return Ok(); // Return 200 OK status
        }

        // DELETE request to remove a player by ID
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePlayer(int id)
        {
            var player = await _playerContext.Players.Include(p => p.GameLog).FirstOrDefaultAsync(p => p.ID == id);

            if (player == null)
            {
                return NotFound();
            }

            // Remove associated game sets
            _playerContext.GameSets.RemoveRange(player.GameLog);

            _playerContext.Players.Remove(player);
            await _playerContext.SaveChangesAsync();

            return Ok();
        }


        //Post method you provided me for the newly added GameSet stat
        [HttpPost("{id}/AddGameSet")]
        public async Task<ActionResult<GameSet>> AddGameSet(int id, GameSet gameSet)
        {
            var player = await _playerContext.Players.FindAsync(id);

            if (player == null)
            {
                return NotFound(); // Return 404 if the specified player is not found
            }

            player.GameLog.Add(gameSet); // Add the new game set to the player's game log
            await _playerContext.SaveChangesAsync(); // Save changes to the database

            // Return a 201 Created status with the newly created game set's details
            return CreatedAtAction(nameof(GetPlayer), new { id = player.ID }, gameSet);
        }

        [HttpGet("{id}/GameSets")]
        public async Task<ActionResult<IEnumerable<GameSet>>> GetGameSets(int id)
        {
            var player = await _playerContext.Players.Include(p => p.GameLog).FirstOrDefaultAsync(p => p.ID == id);

            if (player == null)
            {
                return NotFound();
            }

            return Ok(player.GameLog);
        }

        [HttpPut("{playerId}/GameSets/{gameSetId}")]
        public async Task<ActionResult> PutGameSet(int playerId, int gameSetId, GameSet gameSet)
        {
            var player = await _playerContext.Players.Include(p => p.GameLog).FirstOrDefaultAsync(p => p.ID == playerId);

            if (player == null)
            {
                return NotFound();
            }

            var existingGameSet = player.GameLog.FirstOrDefault(gs => gs.GameSetID == gameSetId);

            if (existingGameSet == null)
            {
                return NotFound();
            }
            existingGameSet.Date = gameSet.Date;
            existingGameSet.Team = gameSet.Team;
            existingGameSet.Opp = gameSet.Opp;
            existingGameSet.Result = gameSet.Result;
            existingGameSet.Points = gameSet.Points;
            existingGameSet.Rebounds = gameSet.Rebounds;
            existingGameSet.Assists = gameSet.Assists;
            existingGameSet.MinutesPlayed = gameSet.MinutesPlayed;
            existingGameSet.FG = gameSet.FG;
            existingGameSet.FGA = gameSet.FGA;
            existingGameSet.ThreePoint = gameSet.ThreePoint;
            existingGameSet.ThreePointAttempt = gameSet.ThreePointAttempt;
            existingGameSet.FreeThrow = gameSet.FreeThrow;
            existingGameSet.FreeThrowAttempt = gameSet.FreeThrowAttempt;
            existingGameSet.Oreb = gameSet.Oreb;
            existingGameSet.Dreb = gameSet.Dreb;
            existingGameSet.Tov = gameSet.Tov;
            existingGameSet.Blk = gameSet.Blk;
            existingGameSet.Stl = gameSet.Stl;
            existingGameSet.PersonalFouls = gameSet.PersonalFouls;

            await _playerContext.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{playerId}/GameSets/{gameSetId}")]
        public async Task<ActionResult> DeleteGameSet(int playerId, int gameSetId)
        {
            var player = await _playerContext.Players.Include(p => p.GameLog).FirstOrDefaultAsync(p => p.ID == playerId);

            if (player == null)
            {
                return NotFound();
            }

            var gameSetToRemove = player.GameLog.FirstOrDefault(gs => gs.GameSetID == gameSetId);

            if (gameSetToRemove == null)
            {
                return NotFound();
            }

            // Remove the game set from the context
            _playerContext.GameSets.Remove(gameSetToRemove);

            // Remove the game set from the player's game log
            player.GameLog.Remove(gameSetToRemove);

            await _playerContext.SaveChangesAsync();

            return Ok();
        }
    }
}
