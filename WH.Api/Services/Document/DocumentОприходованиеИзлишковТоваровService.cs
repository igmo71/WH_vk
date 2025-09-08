using Microsoft.EntityFrameworkCore;
using WH.Api.Data;
using WH.Api.OData;
using WH.Api.OData.ODataParameters.Document;
using WH.Domain.Models.Document;

namespace WH.Api.Services.Document
{
    public interface IDocumentОприходованиеИзлишковТоваровService : IDocumentService
    { }

    public class DocumentОприходованиеИзлишковТоваровService : DocumentService<DocumentОприходованиеИзлишковТоваров>, IDocumentОприходованиеИзлишковТоваровService
    {
        public DocumentОприходованиеИзлишковТоваровService(
            IODataClient oDataClient,
            IDocumentОприходованиеИзлишковТоваровParameters oDataParameters,
            IDbContextFactory<AppDbContext> dbContextFactory,
            ILogger<DocumentОприходованиеИзлишковТоваровService> logger,
            IConfiguration configuration)
        : base(oDataClient, oDataParameters, dbContextFactory, logger, configuration)
        { }

    }
}
