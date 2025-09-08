using Microsoft.AspNetCore.Mvc;
using WH.Api.Services;
using WH.Api.Services.Awesome;

namespace WH.Api.Controllers.Awesome
{
    [Route("api/[controller]")]
    [ApiController]
    public class AwesomeТоварыНаСкладахRecordTypeОперацияЦеныController : ControllerBase
    {
        private readonly IAwesomeТоварыНаСкладахRecordTypeОперацияЦеныService _service;

        public AwesomeТоварыНаСкладахRecordTypeОперацияЦеныController(IAwesomeТоварыНаСкладахRecordTypeОперацияЦеныService service)
        {
            _service = service;
        }

        [HttpGet("date-period")]
        public async Task<ActionResult<ServiceResult>> LoadAsync(DateTime dateBegin, DateTime dateEnd)
        {
            var result = await _service.LoadingAsync(dateBegin, dateEnd);
            return result;
        }

        [HttpGet("year-month")]
        public async Task<ActionResult<ServiceResult>> LoadingAsync(int year, int month)
        {
            var result = await _service.LoadingAsync(year, month);
            return Ok(result);
        }

        [HttpGet("lasttriple-month")]
        public async Task<ActionResult<List<ServiceResult>>> LoadingLastTripleMonthsAsync()
        {
            var result = await _service.LoadingLastTripleMonthsAsync();
            return Ok(result);
        }
    }
}
