using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Document;
using WH.Domain.Models.Document;

namespace WH.Api.Services.Document
{
    public interface IDocumentПриходныйОрдерНаТоварыService : IDocumentService
    { }

    public class DocumentПриходныйОрдерНаТоварыService : DocumentService<DocumentПриходныйОрдерНаТовары>, IDocumentПриходныйОрдерНаТоварыService
    {
        public DocumentПриходныйОрдерНаТоварыService(
            IODataClient oDataClient,
            IDocumentПриходныйОрдерНаТоварыParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<DocumentПриходныйОрдерНаТоварыService> logger,
            IConfiguration configuration)
        : base(oDataClient, oDataParameters, dbContextFactory, logger, configuration)
        { }
    }
}
