using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Document;
using WH.Domain.Models.Document;

namespace WH.Api.Services.Document
{
    public interface IDocumentВозвратТоваровОтКлиентаService : IDocumentService
    { }

    public class DocumentВозвратТоваровОтКлиентаService : DocumentService<DocumentВозвратТоваровОтКлиента>, IDocumentВозвратТоваровОтКлиентаService
    {
        public DocumentВозвратТоваровОтКлиентаService(
            IODataClient oDataClient,
            IDocumentВозвратТоваровОтКлиентаParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<DocumentВозвратТоваровОтКлиентаService> logger,
            IConfiguration configuration)
        : base(oDataClient, oDataParameters, dbContextFactory, logger, configuration)
        { }
    }
}
