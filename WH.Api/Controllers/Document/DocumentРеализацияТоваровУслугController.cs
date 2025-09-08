using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Document;

namespace WH.Api.Controllers.Document
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentРеализацияТоваровУслугController : DocumentController
    {
        public DocumentРеализацияТоваровУслугController(IDocumentРеализацияТоваровУслугService service) => _service = service;
    }
}
