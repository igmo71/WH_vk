using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Controllers.Catalog
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogПартнерыController : CatalogController<CatalogПартнеры>
    {
        public CatalogПартнерыController(ICatalogПартнерыService service) => _service = service;
    }
}
