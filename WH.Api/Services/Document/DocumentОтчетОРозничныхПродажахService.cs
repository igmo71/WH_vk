using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Document;
using WH.Domain.Models.Document;

namespace WH.Api.Services.Document
{
    public interface IDocumentОтчетОРозничныхПродажахService : IDocumentService
    { }

    public class DocumentОтчетОРозничныхПродажахService : DocumentService<DocumentОтчетОРозничныхПродажах>, IDocumentОтчетОРозничныхПродажахService
    {
        public DocumentОтчетОРозничныхПродажахService(
            IODataClient oDataClient,
            IDocumentОтчетОРозничныхПродажахParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<DocumentОтчетОРозничныхПродажахService> logger,
            IConfiguration configuration)
        : base(oDataClient, oDataParameters, dbContextFactory, logger, configuration)
        {

        }
    }
}
