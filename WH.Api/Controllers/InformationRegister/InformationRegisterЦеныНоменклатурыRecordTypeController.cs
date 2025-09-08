using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.InformationRegister;

namespace WH.Api.Controllers.InformationRegister
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationRegisterЦеныНоменклатурыRecordTypeController : InformationRegisterPeriodicController
    {
        public InformationRegisterЦеныНоменклатурыRecordTypeController(
            IInformationRegisterЦеныНоменклатурыRecordTypeService service) =>
                _service = service;
    }
}
