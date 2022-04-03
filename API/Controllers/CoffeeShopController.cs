using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CoffeeShopController : ControllerBase
    {
        private readonly ICoffeeShopService _coffeeShopService;

        public CoffeeShopController(ICoffeeShopService coffeeShopService)
        {
            _coffeeShopService = coffeeShopService;
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            var items = await _coffeeShopService.List();

            return Ok(items);
        }
    }
}
