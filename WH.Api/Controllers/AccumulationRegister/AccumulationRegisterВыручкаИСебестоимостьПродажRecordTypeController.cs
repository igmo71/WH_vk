using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.AccumulationRegister;

namespace WH.Api.Controllers.AccumulationRegister
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeController : AccumulationRegisterController
    {
        public AccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeController(IAccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeService service) =>
                _service = service;
    }
}
