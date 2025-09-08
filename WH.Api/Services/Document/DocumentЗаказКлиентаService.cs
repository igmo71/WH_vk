using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Document;
using WH.Domain.Models.Document;

namespace WH.Api.Services.Document
{
    public interface IDocumentЗаказКлиентаService : IDocumentService
    { }

    public class DocumentЗаказКлиентаService : DocumentService<DocumentЗаказКлиента>, IDocumentЗаказКлиентаService
    {
        public DocumentЗаказКлиентаService(
            IODataClient oDataClient,
            IDocumentЗаказКлиентаParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<DocumentЗаказКлиентаService> logger,
            IConfiguration configuration)
        : base(oDataClient, oDataParameters, dbContextFactory, logger, configuration)
        { }
    }
}
