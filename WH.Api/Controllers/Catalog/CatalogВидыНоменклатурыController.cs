using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Controllers.Catalog
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogВидыНоменклатурыController : CatalogController<CatalogВидыНоменклатуры>
    {
        public CatalogВидыНоменклатурыController(ICatalogВидыНоменклатурыService service) => _service = service;
    }
}
