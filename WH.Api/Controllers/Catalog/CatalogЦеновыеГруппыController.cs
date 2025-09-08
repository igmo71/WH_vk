using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Controllers.Catalog
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogЦеновыеГруппыController : CatalogController<CatalogЦеновыеГруппы>
    {
        public CatalogЦеновыеГруппыController(ICatalogЦеновыеГруппыService service) => _service = service;
    }
}
