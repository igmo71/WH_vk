using Microsoft.AspNetCore.Mvc;
using WH.Api.Controllers.AccumulationRegister;
using WH.Api.Services.Wms;

namespace WH.Api.Controllers.Wms
{
    [Route("api/[controller]")]
    [ApiController]
    public class WmsAccumulationRegisterТоварыВЯчейкахBalanceAndTurnoversController : AccumulationRegisterController
    {
        public WmsAccumulationRegisterТоварыВЯчейкахBalanceAndTurnoversController(IAccumulationRegisterТоварыВЯчейкахBalanceAndTurnoversService service)
        {
            _service = service;
        }
    }
}
