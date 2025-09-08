using Microsoft.AspNetCore.Mvc;
using WH.Api.Services;
using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Controllers.AccumulationRegister
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversController : AccumulationRegisterController
    {
        public AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversController(IAccumulationRegisterТоварыНаСкладахBalanceAndTurnoversService service) =>
                _service = service;

        [HttpGet("closing-balance")]
        public async Task<ActionResult<ServiceResult>> GetODataAndDbGetClosingBalanceAsync(DateTime date)
        {
            if (_service == null)
                return Problem(detail: "AccumulationRegister Service not found");

            ServiceResult result = await ((AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversService)_service).GetODataAndDbClosingBalanceAsync(date);
            return Ok(result);
        }
    }
}
