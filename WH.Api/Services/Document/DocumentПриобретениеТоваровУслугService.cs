using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Document;
using WH.Domain.Models.Document;

namespace WH.Api.Services.Document
{
    public interface IDocumentПриобретениеТоваровУслугService : IDocumentService
    { }

    public class DocumentПриобретениеТоваровУслугService : DocumentService<DocumentПриобретениеТоваровУслуг>, IDocumentПриобретениеТоваровУслугService
    {
        public DocumentПриобретениеТоваровУслугService(
            IODataClient oDataClient,
            IDocumentПриобретениеТоваровУслугParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<DocumentПриобретениеТоваровУслугService> logger,
            IConfiguration configuration)
        : base(oDataClient, oDataParameters, dbContextFactory, logger, configuration)
        { }
    }
}
