using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Document;

namespace WH.Api.Controllers.Document
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentОтчетОРозничныхПродажахController : DocumentController
    {
        public DocumentОтчетОРозничныхПродажахController(IDocumentОтчетОРозничныхПродажахService service) => _service = service;
    }
}
