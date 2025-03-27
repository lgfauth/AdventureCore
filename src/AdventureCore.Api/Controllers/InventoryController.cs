using AdventureCore.Application.Models.Request;
using AdventureCore.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AdventureCore.Api.Controllers
{
    public class InventoryController : Controller
    {
        private readonly IInventoryService _inventoryService;

        public InventoryController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetInventory()
        {
            var playerId = User.Identity?.Name;
            var result = await _inventoryService.GetInventoryAsync(playerId);
            return Ok(result);
        }

        [HttpPost("use")]
        public async Task<IActionResult> UseItem([FromBody] UseItemRequest request)
        {
            var playerId = User.Identity?.Name;
            var result = await _inventoryService.UseItemAsync(playerId, request.ItemId);
            return Ok(result);
        }
    }
}
