using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Controllers.Catalog
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogМаркиController : CatalogController<CatalogМарки>
    {
        public CatalogМаркиController(ICatalogМаркиService service) => _service = service;
    }
}
