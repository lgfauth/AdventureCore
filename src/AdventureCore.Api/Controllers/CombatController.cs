using AdventureCore.Application.Models.Request;
using AdventureCore.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdventureCore.Api.Controllers
{
    public class CombatController : Controller
    {
        private readonly ICombatService _combatService;

        public CombatController(ICombatService combatService)
        {
            _combatService = combatService;
        }

        [HttpPost]
        public async Task<IActionResult> Resolve([FromBody] ResolveCombatRequest request)
        {
            var playerId = User.Identity?.Name;
            var result = await _combatService.ResolveCombatAsync(playerId, request);
            return Ok(result);
        }
    }
}
