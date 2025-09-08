using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Document;
using WH.Domain.Models.Document;

namespace WH.Api.Services.Document
{
    public interface IDocumentЗаказНаПеремещениеService : IDocumentService
    { }

    public class DocumentЗаказНаПеремещениеService : DocumentService<DocumentЗаказНаПеремещение>, IDocumentЗаказНаПеремещениеService
    {
        public DocumentЗаказНаПеремещениеService(
            IODataClient oDataClient,
            IDocumentЗаказНаПеремещениеParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<DocumentЗаказНаПеремещениеService> logger,
            IConfiguration configuration)
        : base(oDataClient, oDataParameters, dbContextFactory, logger, configuration)
        { }
    }
}
