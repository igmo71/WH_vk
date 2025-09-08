using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.InformationRegister;
using WH.Domain.Models.InformationRegister;

namespace WH.Api.Services.InformationRegister
{
    public interface IInformationRegisterЦеныНоменклатурыRecordTypeService : IInformationRegisterPeriodicService
    { }

    public class InformationRegisterЦеныНоменклатурыRecordTypeService : InformationRegisterPeriodicService<InformationRegisterЦеныНоменклатурыRecordType>, IInformationRegisterЦеныНоменклатурыRecordTypeService
    {
        public InformationRegisterЦеныНоменклатурыRecordTypeService(
            IODataClient oDataClient,
            IInformationRegisterЦеныНоменклатурыRecordTypeParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<InformationRegisterЦеныНоменклатурыRecordTypeService> logger,
            IConfiguration configuration)
        : base(
              oDataClient,
              oDataParameters,
              dbContextFactory,
              logger,
              configuration)
        {

        }
    }
}
