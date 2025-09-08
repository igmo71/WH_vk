using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Document;

namespace WH.Api.Controllers.Document
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentОприходованиеИзлишковТоваровController : DocumentController
    {
        public DocumentОприходованиеИзлишковТоваровController(IDocumentОприходованиеИзлишковТоваровService service) => _service = service;
    }
}
