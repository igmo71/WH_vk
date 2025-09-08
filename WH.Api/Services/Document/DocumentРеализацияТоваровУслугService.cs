using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Document;
using WH.Domain.Models.Document;

namespace WH.Api.Services.Document
{
    public interface IDocumentРеализацияТоваровУслугService : IDocumentService
    { }

    public class DocumentРеализацияТоваровУслугService : DocumentService<DocumentРеализацияТоваровУслуг>, IDocumentРеализацияТоваровУслугService
    {
        public DocumentРеализацияТоваровУслугService(
            IODataClient oDataClient,
            IDocumentРеализацияТоваровУслугParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<DocumentService<DocumentРеализацияТоваровУслуг>> logger,
            IConfiguration configuration)
        : base(oDataClient, oDataParameters, dbContextFactory, logger, configuration)
        { }
    }
}
