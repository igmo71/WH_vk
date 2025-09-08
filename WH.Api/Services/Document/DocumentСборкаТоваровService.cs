using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Document;
using WH.Domain.Models.Document;

namespace WH.Api.Services.Document
{
    public interface IDocumentСборкаТоваровService : IDocumentService
    { }

    public class DocumentСборкаТоваровService : DocumentService<DocumentСборкаТоваров>, IDocumentСборкаТоваровService
    {
        public DocumentСборкаТоваровService(
            IODataClient oDataClient,
            IDocumentСборкаТоваровParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<DocumentСборкаТоваровService> logger,
            IConfiguration configuration)
        : base(oDataClient, oDataParameters, dbContextFactory, logger, configuration)
        { }
    }
}
