using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Document;

namespace WH.Api.Controllers.Document
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentСборкаТоваровController : DocumentController
    {
        public DocumentСборкаТоваровController(IDocumentСборкаТоваровService service) => _service = service;
    }
}
