using Microsoft.AspNetCore.Mvc;
using WH.Api.Controllers.Catalog;
using WH.Api.Services.Wms;
using WH.Domain.Models.Wms;

namespace WH.Api.Controllers.Wms
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogЯчейкиController : CatalogController<CatalogЯчейки>
    {
        public CatalogЯчейкиController(ICatalogЯчейкиService service) => _service = service;
    }
}
