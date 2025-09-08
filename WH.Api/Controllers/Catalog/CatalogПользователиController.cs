using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Controllers.Catalog
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogПользователиController : CatalogController<CatalogПользователи>
    {
        public CatalogПользователиController(ICatalogПользователиService service) => _service = service;
    }
}
