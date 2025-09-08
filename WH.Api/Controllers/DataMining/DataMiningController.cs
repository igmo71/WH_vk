using Microsoft.AspNetCore.Mvc;
using WH.Api.DataMining;
using WH.Api.Services;

namespace WH.Api.Controllers.DataMining
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataMiningController(IDataMiningService service) : ControllerBase
    {
        [HttpGet("loading-predicts")]
        public async Task<ActionResult<ServiceResult>> LoadingPredictsAsync()
        {
            var result = await service.LoadingPredictsAsync();
            return Ok(result);
        }

        [HttpGet("loading-scu-sale-ranks")]
        public async Task<ActionResult<ServiceResult>> LoadingCubeAsync()
        {
            var result = await service.LoadingScuSaleRanksAsync();
            return Ok(result);
        }
    }
}
