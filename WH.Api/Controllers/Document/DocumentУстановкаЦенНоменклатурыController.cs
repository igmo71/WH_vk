using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Document;

namespace WH.Api.Controllers.Document
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentУстановкаЦенНоменклатурыController : DocumentController
    {
        public DocumentУстановкаЦенНоменклатурыController(IDocumentУстановкаЦенНоменклатурыService service) => _service = service;
    }
}
