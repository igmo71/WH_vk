using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Document;

namespace WH.Api.Controllers.Document
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentПриходныйОрдерНаТоварыController : DocumentController
    {
        public DocumentПриходныйОрдерНаТоварыController(IDocumentПриходныйОрдерНаТоварыService service) => _service = service;
    }
}
