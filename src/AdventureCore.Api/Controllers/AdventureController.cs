using AdventureCore.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdventureCore.Api.Controllers
{
    public class AdventureController : Controller
    {
        private readonly IAdventureService _adventureService;

        public AdventureController(IAdventureService adventureService)
        {
            _adventureService = adventureService;
        }

        [HttpPost]
        public async Task<IActionResult> Explore()
        {
            var playerId = User.Identity?.Name;
            var result = await _adventureService.ExploreAsync(playerId);

            return Ok(result);
        }
    }
}