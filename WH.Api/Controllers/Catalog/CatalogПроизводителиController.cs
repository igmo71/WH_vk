using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Controllers.Catalog
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogПроизводителиController : CatalogController<CatalogПроизводители>
    {
        public CatalogПроизводителиController(ICatalogПроизводителиService service) => _service = service;
    }
}
