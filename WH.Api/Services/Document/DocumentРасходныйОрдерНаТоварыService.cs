using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Document;
using WH.Domain.Models.Document;

namespace WH.Api.Services.Document
{
    public interface IDocumentРасходныйОрдерНаТоварыService : IDocumentService
    { }

    public class DocumentРасходныйОрдерНаТоварыService : DocumentService<DocumentРасходныйОрдерНаТовары>, IDocumentРасходныйОрдерНаТоварыService
    {
        public DocumentРасходныйОрдерНаТоварыService(
            IODataClient oDataClient,
            IDocumentРасходныйОрдерНаТоварыParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<DocumentРасходныйОрдерНаТоварыService> logger,
            IConfiguration configuration)
        : base(oDataClient, oDataParameters, dbContextFactory, logger, configuration)
        { }
    }
}
