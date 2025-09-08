using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Document;

namespace WH.Api.Controllers.Document
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentЗаказНаПеремещениеController : DocumentController
    {
        public DocumentЗаказНаПеремещениеController(IDocumentЗаказНаПеремещениеService service) => _service = service;
    }
}
