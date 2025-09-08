using Microsoft.AspNetCore.Mvc;
using WH.Api.Services;

namespace WH.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AllController : ControllerBase
    {
        private readonly IAllService _service;
        public AllController(IAllService service)
        {
            _service = service;
        }

        [HttpGet("date-period")]
        public async Task<ActionResult<ServiceResult>> LoadingAsync(DateTime begin, DateTime end)
        {
            List<ServiceResult> result = await _service.LoadingAsync(begin, end);

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
