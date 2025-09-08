using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Controllers.Catalog
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogЗначенияСвойствОбъектовController : CatalogController<CatalogЗначенияСвойствОбъектов>
    {
        public CatalogЗначенияСвойствОбъектовController(ICatalogЗначенияСвойствОбъектовService service) => _service = service;
    }
}
