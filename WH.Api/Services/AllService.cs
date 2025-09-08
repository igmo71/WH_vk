using WH.Api.DataMining;
using WH.Api.Services.AccumulationRegister;
using WH.Api.Services.Awesome;
using WH.Api.Services.Catalog;
using WH.Api.Services.Document;
using WH.Api.Services.InformationRegister;
using WH.Api.Services.Wms;
using WH.Api.Voximplant;

namespace WH.Api.Services
{
    public interface IAllService
    {
        Task<List<ServiceResult>> LoadingAsync(DateTime begin, DateTime end);
        Task<List<ServiceResult>> LoadingLastTripleMonthsAsync();
    }

    public class AllService : IAllService
    {
        private readonly ICatalogsAllService _catalogsAllService;

        private readonly IDocumentsAllService _documentsAllService;

        private readonly IInformationRegisterЦеныНоменклатурыRecordTypeService _informationRegisterЦеныНоменклатурыRecordTypeService;
        private readonly IInformationRegisterЦеныНоменклатурыЗакупочныеSliceLastService _informationRegisterЦеныНоменклатурыЗакупочныеSliceLastService;
        private readonly IInformationRegisterЦеныНоменклатурыПоставкиSliceLastService _informationRegisterЦеныНоменклатурыПоставкиSliceLastService;

        private readonly IAccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeService _accumulationRegisterВыручкаИСебестоимостьПродажRecordTypeService;
        private readonly IAccumulationRegisterВыручкаИСебестоимостьПродажTurnoversService _accumulationRegisterВыручкаИСебестоимостьПродажTurnoversService;
        private readonly IAccumulationRegisterГрафикПоступленияТоваровRecordTypeService _accumulationRegisterГрафикПоступленияТоваровRecordTypeService;
        private readonly IAccumulationRegisterЗакупкиRecordTypeService _accumulationRegisterЗакупкиRecordTypeService;
        private readonly IAccumulationRegisterТоварыНаСкладахBalanceAndTurnoversService _accumulationRegisterТоварыНаСкладахBalanceAndTurnoversService;
        private readonly IAccumulationRegisterТоварыНаСкладахBalanceService _accumulationRegisterТоварыНаСкладахBalanceService;
        private readonly IAccumulationRegisterТоварыНаСкладахRecordTypeService _accumulationRegisterТоварыНаСкладахRecordTypeService;

        private readonly IAwesomeТоварыНаСкладахRecordTypeОперацияЦеныService _awesomeТоварыНаСкладахRecordTypeОперацияЦеныService;

        private readonly IAccumulationRegisterТоварыВЯчейкахBalanceAndTurnoversService _accumulationRegisterТоварыВЯчейкахBalanceAndTurnoversService;

        private readonly IDataMiningService _dataMiningService;

        private readonly IVoximplantService _voximplantService;

        public AllService(
            ICatalogsAllService catalogsAllService,

            IDocumentsAllService documentsAllService,

            IInformationRegisterЦеныНоменклатурыRecordTypeService informationRegisterЦеныНоменклатурыRecordTypeService,
            IInformationRegisterЦеныНоменклатурыЗакупочныеSliceLastService informationRegisterЦеныНоменклатурыЗакупочныеSliceLastService,
            IInformationRegisterЦеныНоменклатурыПоставкиSliceLastService informationRegisterЦеныНоменклатурыПоставкиSliceLastService,

            IAccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeService accumulationRegisterВыручкаИСебестоимостьПродажRecordTypeService,
            IAccumulationRegisterВыручкаИСебестоимостьПродажTurnoversService accumulationRegisterВыручкаИСебестоимостьПродажTurnoversService,
            IAccumulationRegisterГрафикПоступленияТоваровRecordTypeService accumulationRegisterГрафикПоступленияТоваровRecordTypeService,
            IAccumulationRegisterЗакупкиRecordTypeService accumulationRegisterЗакупкиRecordTypeService,
            IAccumulationRegisterТоварыНаСкладахBalanceAndTurnoversService accumulationRegisterТоварыНаСкладахBalanceAndTurnoversService,
            IAccumulationRegisterТоварыНаСкладахBalanceService accumulationRegisterТоварыНаСкладахBalanceService,
            IAccumulationRegisterТоварыНаСкладахRecordTypeService accumulationRegisterТоварыНаСкладахRecordTypeService,

            IAwesomeТоварыНаСкладахRecordTypeОперацияЦеныService awesomeТоварыНаСкладахRecordTypeОперацияЦеныService,

            IAccumulationRegisterТоварыВЯчейкахBalanceAndTurnoversService accumulationRegisterТоварыВЯчейкахBalanceAndTurnoversService,

            IDataMiningService dataMiningService,

            IVoximplantService voximplantService)
        {
            _catalogsAllService = catalogsAllService;

            _documentsAllService = documentsAllService;

            _informationRegisterЦеныНоменклатурыRecordTypeService = informationRegisterЦеныНоменклатурыRecordTypeService;
            _informationRegisterЦеныНоменклатурыЗакупочныеSliceLastService = informationRegisterЦеныНоменклатурыЗакупочныеSliceLastService;
            _informationRegisterЦеныНоменклатурыПоставкиSliceLastService = informationRegisterЦеныНоменклатурыПоставкиSliceLastService;

            _accumulationRegisterВыручкаИСебестоимостьПродажRecordTypeService = accumulationRegisterВыручкаИСебестоимостьПродажRecordTypeService;
            _accumulationRegisterВыручкаИСебестоимостьПродажTurnoversService = accumulationRegisterВыручкаИСебестоимостьПродажTurnoversService;
            _accumulationRegisterГрафикПоступленияТоваровRecordTypeService = accumulationRegisterГрафикПоступленияТоваровRecordTypeService;
            _accumulationRegisterЗакупкиRecordTypeService = accumulationRegisterЗакупкиRecordTypeService;
            _accumulationRegisterТоварыНаСкладахBalanceAndTurnoversService = accumulationRegisterТоварыНаСкладахBalanceAndTurnoversService;
            _accumulationRegisterТоварыНаСкладахBalanceService = accumulationRegisterТоварыНаСкладахBalanceService;
            _accumulationRegisterТоварыНаСкладахRecordTypeService = accumulationRegisterТоварыНаСкладахRecordTypeService;

            _awesomeТоварыНаСкладахRecordTypeОперацияЦеныService = awesomeТоварыНаСкладахRecordTypeОперацияЦеныService;

            _accumulationRegisterТоварыВЯчейкахBalanceAndTurnoversService = accumulationRegisterТоварыВЯчейкахBalanceAndTurnoversService;

            _dataMiningService = dataMiningService;

            _voximplantService = voximplantService;
        }

        public async Task<List<ServiceResult>> LoadingAsync(DateTime begin, DateTime end)
        {
            var result = new List<ServiceResult>();

            //result.AddRange(await _catalogsAllService.LoadingAsync());

            result.AddRange(await _documentsAllService.LoadingAsync(begin, end));

            result.Add(await _informationRegisterЦеныНоменклатурыRecordTypeService.LoadingAsync(begin, end));
            result.Add(await _informationRegisterЦеныНоменклатурыЗакупочныеSliceLastService.LoadingAsync(begin, end));
            result.Add(await _informationRegisterЦеныНоменклатурыПоставкиSliceLastService.LoadingAsync(begin, end));

            result.Add(await _accumulationRegisterВыручкаИСебестоимостьПродажRecordTypeService.LoadingAsync(begin, end));
            result.Add(await _accumulationRegisterВыручкаИСебестоимостьПродажTurnoversService.LoadingAsync(begin, end));
            result.Add(await _accumulationRegisterЗакупкиRecordTypeService.LoadingAsync(begin, end));
            result.Add(await _accumulationRegisterТоварыНаСкладахBalanceAndTurnoversService.LoadingAsync(begin, end));
            result.Add(await _accumulationRegisterТоварыНаСкладахBalanceService.LoadingAsync(begin, end));
            result.Add(await _accumulationRegisterТоварыНаСкладахRecordTypeService.LoadingAsync(begin, end));

            result.Add(await _awesomeТоварыНаСкладахRecordTypeОперацияЦеныService.LoadingAsync(begin, end));

            result.Add(await _accumulationRegisterТоварыВЯчейкахBalanceAndTurnoversService.LoadingAsync(begin, end));

            result.Add(await _dataMiningService.LoadingPredictsAsync());
            result.Add(await _dataMiningService.LoadingScuSaleRanksAsync());

            result.Add(await _voximplantService.LoadingCurrentMonthAsync());

            return result;
        }

        public async Task<List<ServiceResult>> LoadingLastTripleMonthsAsync()
        {

            var result = new List<ServiceResult>();

            //result.AddRange(await _catalogsAllService.LoadingAsync());

            result.AddRange(await _documentsAllService.LoadingLastTripleMonthsAsync());

            result.AddRange(await _informationRegisterЦеныНоменклатурыRecordTypeService.LoadingLastTripleMonthsAsync());
            result.AddRange(await _informationRegisterЦеныНоменклатурыЗакупочныеSliceLastService.LoadingLastTripleMonthsAsync());
            result.AddRange(await _informationRegisterЦеныНоменклатурыПоставкиSliceLastService.LoadingLastTripleMonthsAsync());

            result.AddRange(await _accumulationRegisterВыручкаИСебестоимостьПродажRecordTypeService.LoadingLastTripleMonthsAsync());
            result.AddRange(await _accumulationRegisterВыручкаИСебестоимостьПродажTurnoversService.LoadingLastTripleMonthsAsync());
            result.AddRange(await _accumulationRegisterЗакупкиRecordTypeService.LoadingLastTripleMonthsAsync());
            result.AddRange(await _accumulationRegisterТоварыНаСкладахBalanceAndTurnoversService.LoadingLastTripleMonthsAsync());
            result.AddRange(await _accumulationRegisterТоварыНаСкладахBalanceService.LoadingLastTripleMonthsAsync());
            result.AddRange(await _accumulationRegisterТоварыНаСкладахRecordTypeService.LoadingLastTripleMonthsAsync());

            result.AddRange(await _awesomeТоварыНаСкладахRecordTypeОперацияЦеныService.LoadingLastTripleMonthsAsync());

            result.AddRange(await _accumulationRegisterТоварыВЯчейкахBalanceAndTurnoversService.LoadingLastTripleMonthsAsync());

            result.Add(await _dataMiningService.LoadingPredictsAsync());
            result.Add(await _dataMiningService.LoadingScuSaleRanksAsync());

            result.Add(await _voximplantService.LoadingCurrentMonthAsync());

            return result;
        }
    }
}
