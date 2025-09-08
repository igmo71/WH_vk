using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Document;

namespace WH.Api.Controllers.Document
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentЗаказКлиентаController : DocumentController
    {
        public DocumentЗаказКлиентаController(IDocumentЗаказКлиентаService service) => _service = service;
    }
}
