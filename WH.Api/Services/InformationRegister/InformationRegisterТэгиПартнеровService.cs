using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.InformationRegister;
using WH.Api.Services.Catalog;
using WH.Domain.Models.InformationRegister;

namespace WH.Api.Services.InformationRegister
{
    public interface IInformationRegisterТэгиПартнеровService : ICatalogService
    { }

    public class InformationRegisterТэгиПартнеровService : CatalogService<InformationRegisterТэгиПартнеров>, IInformationRegisterТэгиПартнеровService
    {
        public InformationRegisterТэгиПартнеровService(
            IODataClient oDataClient,
            IInformationRegisterТэгиПартнеровParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<InformationRegisterТэгиПартнеровService> logger)
        : base(oDataClient, oDataParameters, dbContextFactory, logger)
        { }
    }
}
