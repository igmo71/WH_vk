using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Document;
using WH.Domain.Models.Document;

namespace WH.Api.Services.Document
{
    public interface IDocumentУстановкаЦенНоменклатурыService : IDocumentService
    { }

    public class DocumentУстановкаЦенНоменклатурыService : DocumentService<DocumentУстановкаЦенНоменклатуры>, IDocumentУстановкаЦенНоменклатурыService
    {
        public DocumentУстановкаЦенНоменклатурыService(
            IODataClient oDataClient,
            IDocumentУстановкаЦенНоменклатурыParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<DocumentУстановкаЦенНоменклатурыService> logger,
            IConfiguration configuration)
        : base(oDataClient, oDataParameters, dbContextFactory, logger, configuration)
        { }
    }
}
