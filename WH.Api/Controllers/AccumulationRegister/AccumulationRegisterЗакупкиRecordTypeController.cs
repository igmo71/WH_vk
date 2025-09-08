using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Controllers.AccumulationRegister
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccumulationRegisterЗакупкиRecordTypeController : AccumulationRegisterController
    {
        public AccumulationRegisterЗакупкиRecordTypeController(IAccumulationRegisterЗакупкиRecordTypeService service) =>
                _service = service;
    }
}
