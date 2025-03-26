using AdventureCore.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace AdventureCore.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class PlayersController : ControllerBase
    {
        //private readonly IPlayerService _playerService;

        public PlayersController()//IPlayerService playerService)
        {
            //_playerService = playerService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] PlayerRequest player)
        {
            //var result = await _playerService.CreatePlayerAsync(dto);
            return Ok(player);
        }

        //[HttpGet("me")]
        //public async Task<IActionResult> GetCurrentPlayer()
        //{
        //    var playerId = User.Identity?.Name; // Simulação de obtenção de ID do JWT
        //    var result = await _playerService.GetPlayerByIdAsync(playerId);
        //    return Ok(result);
        //}
    }
}
