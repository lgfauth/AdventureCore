using AdventureCore.Application.Models.Request;
using Microsoft.AspNetCore.Mvc;

namespace AdventureCore.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PlayersController : ControllerBase
    {
        private readonly PlayerService _playerService;

        public PlayersController(PlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PlayerRequest player)
        {
            var result = await _playerService.CreatePlayerAsync(player);

            return Ok(player);
        }

        [HttpGet("me")]
        public async Task<IActionResult> GetCurrentPlayer()
        {
            var playerId = User.Identity?.Name; // Simulação de obtenção de ID do JWT
            var result = await _playerService.GetPlayerByIdAsync(playerId);

            return Ok(result);
        }
    }
}
