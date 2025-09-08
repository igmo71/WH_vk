using Microsoft.AspNetCore.Mvc;
using WH.Api.Services;

namespace WH.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController(CurrencyService currencyService) : ControllerBase
    {
        private readonly CurrencyService _currencyService = currencyService;

        [HttpGet("load")]
        public async Task<IActionResult> LoadRates([FromQuery] DateTime? from, [FromQuery] DateTime? to, [FromQuery] string? code)
        {
            var result = await _currencyService.FetchAndStoreRatesAsync(from, to, code);

            return Ok(result);
        }
    }
}
