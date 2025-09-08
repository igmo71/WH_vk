using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Controllers.AccumulationRegister
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccumulationRegisterТоварыНаСкладахRecordTypeController : AccumulationRegisterController
    {
        public AccumulationRegisterТоварыНаСкладахRecordTypeController(IAccumulationRegisterТоварыНаСкладахRecordTypeService service) =>
                _service = service;
    }
}
