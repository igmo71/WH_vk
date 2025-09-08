using Microsoft.AspNetCore.Mvc;
using WH.Api.Controllers.Catalog;
using WH.Api.Services.InformationRegister;
using WH.Domain.Models.InformationRegister;

namespace WH.Api.Controllers.InformationRegister
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationRegisterТэгиПартнеровController : CatalogController<InformationRegisterТэгиПартнеров>
    {
        public InformationRegisterТэгиПартнеровController(IInformationRegisterТэгиПартнеровService service) => _service = service;
    }
}
