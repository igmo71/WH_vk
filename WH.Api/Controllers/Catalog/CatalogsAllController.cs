using Microsoft.AspNetCore.Mvc;
using WH.Api.Services;
using WH.Api.Services.Catalog;

namespace WH.Api.Controllers.Catalog
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogsAllController : ControllerBase
    {
        private readonly ICatalogsAllService _catalogsAllService;

        public CatalogsAllController(ICatalogsAllService catalogsAllService)
        {
            _catalogsAllService = catalogsAllService;
        }

        [HttpGet("loading")]
        public async Task<ActionResult<List<ServiceResult>>> LoadingAsync()
        {
            if (_catalogsAllService == null)
                return Problem(detail: "Catalog Service not found");

            var result = await _catalogsAllService.LoadingAsync();
            return Ok(result);
        }
    }
}
