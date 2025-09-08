using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Document;

namespace WH.Api.Controllers.Document
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentПриобретениеТоваровУслугController : DocumentController
    {
        public DocumentПриобретениеТоваровУслугController(IDocumentПриобретениеТоваровУслугService service) => _service = service;
    }
}
