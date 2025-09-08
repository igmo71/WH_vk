using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Document;

namespace WH.Api.Controllers.Document
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentВозвратТоваровОтКлиентаController : DocumentController
    {
        public DocumentВозвратТоваровОтКлиентаController(IDocumentВозвратТоваровОтКлиентаService service) => _service = service;
    }
}
