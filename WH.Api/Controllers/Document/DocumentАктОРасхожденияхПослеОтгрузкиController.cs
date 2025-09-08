using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Document;

namespace WH.Api.Controllers.Document
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentАктОРасхожденияхПослеОтгрузкиController : DocumentController
    {
        public DocumentАктОРасхожденияхПослеОтгрузкиController(IDocumentАктОРасхожденияхПослеОтгрузкиService service) => _service = service;
    }
}
