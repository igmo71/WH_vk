using Microsoft.AspNetCore.Mvc;
using WH.Api.Services.Catalog;
using WH.Domain.Models.Catalog;

namespace WH.Api.Controllers.Catalog
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogПричиныОтменыЗаказовКлиентовController : CatalogController<CatalogПричиныОтменыЗаказовКлиентов>
    {
        public CatalogПричиныОтменыЗаказовКлиентовController(ICatalogПричиныОтменыЗаказовКлиентовService service) => _service = service;
    }
}
