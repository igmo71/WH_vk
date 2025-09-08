using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Document;
using WH.Domain.Models.Document;

namespace WH.Api.Services.Document
{
    public interface IDocumentАктОРасхожденияхПослеОтгрузкиService : IDocumentService
    { }

    public class DocumentАктОРасхожденияхПослеОтгрузкиService : DocumentService<DocumentАктОРасхожденияхПослеОтгрузки>, IDocumentАктОРасхожденияхПослеОтгрузкиService
    {
        public DocumentАктОРасхожденияхПослеОтгрузкиService(
            IODataClient oDataClient,
            IDocumentАктОРасхожденияхПослеОтгрузкиParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<DocumentАктОРасхожденияхПослеОтгрузкиService> logger,
            IConfiguration configuration)
        : base(oDataClient, oDataParameters, dbContextFactory, logger, configuration)
        {
        }
    }
}
