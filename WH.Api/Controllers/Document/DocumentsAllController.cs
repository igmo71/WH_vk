using Microsoft.AspNetCore.Mvc;
using WH.Api.Services;
using WH.Api.Services.Document;

namespace WH.Api.Controllers.Document
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentsAllController : ControllerBase
    {
        private readonly IDocumentsAllService _documentsAllService;

        public DocumentsAllController(IDocumentsAllService documentsAllService)
        {
            _documentsAllService = documentsAllService;
        }

        [HttpGet("loading")]
        public async Task<ActionResult<List<ServiceResult>>> LoadingAsync()
        {
            if (_documentsAllService == null)
                return Problem(detail: "Document Service not found");

            var result = await _documentsAllService.LoadingLastTripleMonthsAsync();
            return Ok(result);
        }

        [HttpGet("date-period")]
        public async Task<ActionResult<ServiceResult>> LoadingAsync(DateTime begin, DateTime end)
        {
            if (_documentsAllService == null)
                return Problem(detail: "Document Service not found");

            var result = await _documentsAllService.LoadingAsync(begin, end);
            return Ok(result);
        }
    }
}
