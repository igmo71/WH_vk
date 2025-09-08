using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Controllers.Catalog
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogПодвидыНоменклатурыController : CatalogController<CatalogПодвидыНоменклатуры>
    {
        public CatalogПодвидыНоменклатурыController(ICatalogПодвидыНоменклатурыService service) => _service = service;
    }
}
