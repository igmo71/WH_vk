using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Controllers.Catalog
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogБизнесРегионыController : CatalogController<CatalogБизнесРегионы>
    {
        public CatalogБизнесРегионыController(ICatalogБизнесРегионыService service) => _service = service;
    }
}
