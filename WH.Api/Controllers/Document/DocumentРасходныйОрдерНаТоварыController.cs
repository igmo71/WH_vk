using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Document;

namespace WH.Api.Controllers.Document
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentРасходныйОрдерНаТоварыController : DocumentController
    {
        public DocumentРасходныйОрдерНаТоварыController(IDocumentРасходныйОрдерНаТоварыService service) => _service = service;
    }
}
