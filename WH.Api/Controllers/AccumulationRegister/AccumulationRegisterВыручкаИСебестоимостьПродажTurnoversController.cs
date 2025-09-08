using Microsoft.AspNetCore.Mvc;
using WH.Api.Services;
using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Controllers.AccumulationRegister
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccumulationRegisterВыручкаИСебестоимостьПродажTurnoversController : AccumulationRegisterController
    {
        public AccumulationRegisterВыручкаИСебестоимостьПродажTurnoversController(IAccumulationRegisterВыручкаИСебестоимостьПродажTurnoversService service) =>
                _service = service;

        [HttpGet("turnover")]
        public async Task<ActionResult<ServiceResult>> GetODataAndDbСуммаВыручкиTurnoverAsync(DateTime date)
        {
            if (_service == null)
                return Problem(detail: "AccumulationRegister Service not found");

            ServiceResult result = await ((IAccumulationRegisterВыручкаИСебестоимостьПродажTurnoversService)_service).GetODataAndDbСуммаВыручкиTurnoverAsync(date);
            return Ok(result);
        }
    }
}
