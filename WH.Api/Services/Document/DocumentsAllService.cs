namespace WH.Api.Services.Document
{
    public interface IDocumentsAllService
    {
        Task<List<ServiceResult>> LoadingLastTripleMonthsAsync();
        Task<List<ServiceResult>> LoadingAsync(DateTime begin, DateTime end);
    }

    public class DocumentsAllService(
        IDocumentАктОРасхожденияхПослеОтгрузкиService documentАктОРасхожденияхПослеОтгрузкиService,
        IDocumentВозвратТоваровОтКлиентаService documentВозвратТоваровОтКлиентаService,
        IDocumentЗаказКлиентаService documentЗаказКлиентаService,
        IDocumentЗаказНаПеремещениеService documentЗаказНаПеремещениеService,
        IDocumentОприходованиеИзлишковТоваровService documentОприходованиеИзлишковТоваровService,
        IDocumentОтчетОРозничныхПродажахService documentОтчетОРозничныхПродажахService,
        IDocumentПриобретениеТоваровУслугService documentПриобретениеТоваровУслугService,
        IDocumentПриходныйОрдерНаТоварыService documentПриходныйОрдерНаТоварыService,
        IDocumentРасходныйОрдерНаТоварыService documentРасходныйОрдерНаТоварыService,
        IDocumentРеализацияТоваровУслугService documentРеализацияТоваровУслугService,
        IDocumentСборкаТоваровService documentСборкаТоваровService,
        IDocumentУстановкаЦенНоменклатурыService documentУстановкаЦенНоменклатурыService)
        : IDocumentsAllService
    {
        public async Task<List<ServiceResult>> LoadingLastTripleMonthsAsync()
        {
            var result = new List<ServiceResult>();

            result.AddRange(await documentАктОРасхожденияхПослеОтгрузкиService.LoadingLastTripleMonthsAsync());
            result.AddRange(await documentВозвратТоваровОтКлиентаService.LoadingLastTripleMonthsAsync());
            result.AddRange(await documentЗаказКлиентаService.LoadingLastTripleMonthsAsync());
            result.AddRange(await documentЗаказНаПеремещениеService.LoadingLastTripleMonthsAsync());
            result.AddRange(await documentОприходованиеИзлишковТоваровService.LoadingLastTripleMonthsAsync());
            result.AddRange(await documentОтчетОРозничныхПродажахService.LoadingLastTripleMonthsAsync());
            result.AddRange(await documentПриобретениеТоваровУслугService.LoadingLastTripleMonthsAsync());
            result.AddRange(await documentПриходныйОрдерНаТоварыService.LoadingLastTripleMonthsAsync());
            result.AddRange(await documentРасходныйОрдерНаТоварыService.LoadingLastTripleMonthsAsync());
            result.AddRange(await documentРеализацияТоваровУслугService.LoadingLastTripleMonthsAsync());
            result.AddRange(await documentСборкаТоваровService.LoadingLastTripleMonthsAsync());
            result.AddRange(await documentУстановкаЦенНоменклатурыService.LoadingLastTripleMonthsAsync());

            return result;
        }

        public async Task<List<ServiceResult>> LoadingAsync(DateTime begin, DateTime end)
        {
            var result = new List<ServiceResult>
            {
                await documentАктОРасхожденияхПослеОтгрузкиService.LoadingAsync(begin, end),
                await documentВозвратТоваровОтКлиентаService.LoadingAsync(begin, end),
                await documentЗаказКлиентаService.LoadingAsync(begin, end),
                await documentЗаказНаПеремещениеService.LoadingAsync(begin, end),
                await documentОприходованиеИзлишковТоваровService.LoadingAsync(begin, end),
                await documentОтчетОРозничныхПродажахService.LoadingAsync(begin, end),
                await documentПриобретениеТоваровУслугService.LoadingAsync(begin, end),
                await documentПриходныйОрдерНаТоварыService.LoadingAsync(begin, end),
                await documentРасходныйОрдерНаТоварыService.LoadingAsync(begin, end),
                await documentРеализацияТоваровУслугService.LoadingAsync(begin, end),
                await documentСборкаТоваровService.LoadingAsync(begin, end),
                await documentУстановкаЦенНоменклатурыService.LoadingAsync(begin, end)
            };

            return result;
        }
    }
}
