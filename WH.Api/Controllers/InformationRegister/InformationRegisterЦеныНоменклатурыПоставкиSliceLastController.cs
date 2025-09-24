using Microsoft.AspNetCore.Mvc;
using WH.Api.Services;
using WH.Api.Services.InformationRegister;

namespace WH.Api.Controllers.InformationRegister
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationRegisterЦеныНоменклатурыПоставкиSliceLastController : ControllerBase
    {
        private readonly IInformationRegisterЦеныНоменклатурыПоставкиSliceLastService _service;

        public InformationRegisterЦеныНоменклатурыПоставкиSliceLastController(IInformationRegisterЦеныНоменклатурыПоставкиSliceLastService service)
        {
            _service = service;
        }

        [HttpGet("date-period")]
        public async Task<ActionResult<ServiceResult>> LoadingAsync(DateTime begin, DateTime end)
        {
            ServiceResult result = await _service.LoadingAsync(begin, end);
            return Ok(result);
        }

        [HttpGet("year-month")]
        public async Task<ActionResult<ServiceResult>> LoadingAsync(int year, int month)
        {
            ServiceResult result = await _service.LoadingAsync(year, month);
            return Ok(result);
        }

        [HttpGet("lasttriple-month")]
        public async Task<ActionResult<ServiceResult>> LoadingLastTripleMonthsAsync()
        {
            List<ServiceResult> result = await _service.LoadingLastTripleMonthsAsync();
            return Ok(result);
        }
    }
}
