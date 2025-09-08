using Microsoft.AspNetCore.Mvc;
using WH.Api.Services;
using WH.Api.Voximplant;

namespace WH.Api.Controllers.Call
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoximplantController : ControllerBase
    {
        private readonly IVoximplantService _service;

        public VoximplantController(IVoximplantService service)
        {
            _service = service;
        }

        [HttpGet("date-period")]
        public async Task<ActionResult<ServiceResult>> LoadingAsync(DateTime begin, DateTime end)
        {
            if (_service == null)
                return Problem(detail: "Document Service not found");

            ServiceResult result = await _service.LoadingAsync(begin, end);
            return Ok(result);
        }

        [HttpGet("year-month")]
        public async Task<ActionResult<ServiceResult>> LoadingAsync(int year, int month)
        {
            if (_service == null)
                return Problem(detail: "Document Service not found");

            ServiceResult result = await _service.LoadingAsync(year, month);
            return Ok(result);
        }

        [HttpGet("last-days")]
        public async Task<ActionResult<ServiceResult>> LoadingAsync(int lastDays)
        {
            if (_service == null)
                return Problem(detail: "Document Service not found");

            ServiceResult result = await _service.LoadingAsync(lastDays);
            return Ok(result);
        }

        [HttpGet("current-month")]
        public async Task<ActionResult<ServiceResult>> LoadingCurrentMonthAsync()
        {
            if (_service == null)
                return Problem(detail: "Document Service not found");

            ServiceResult result = await _service.LoadingCurrentMonthAsync();
            return Ok(result);
        }

        [HttpGet("previous-month")]
        public async Task<ActionResult<ServiceResult>> LoadingPreviousMonthAsync()
        {
            if (_service == null)
                return Problem(detail: "Document Service not found");

            ServiceResult result = await _service.LoadingPreviousMonthAsync();
            return Ok(result);
        }

        [HttpGet("lastpair-month")]
        public async Task<ActionResult<ServiceResult>> LoadingLastPairMonthsAsync()
        {
            if (_service == null)
                return Problem(detail: "AccumulationRegister Service not found");

            List<ServiceResult> result = await _service.LoadingLastPairMonthsAsync();
            return Ok(result);
        }

        [HttpGet("lasttriple-month")]
        public async Task<ActionResult<ServiceResult>> LoadingLastTripleMonthsAsync()
        {
            if (_service == null)
                return Problem(detail: "AccumulationRegister Service not found");

            List<ServiceResult> result = await _service.LoadingLastTripleMonthsAsync();
            return Ok(result);
        }
    }
}
