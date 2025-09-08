using WH.Api.Services.InformationRegister;
using WH.Api.Services.Trash;

namespace WH.Api.Services.Catalog
{
    public interface ICatalogsAllService
    {
        Task<List<ServiceResult>> LoadingAsync();
    }

    public class CatalogsAllService(
        //ILogger<CatalogsAllService> logger,
        ICatalogБизнесРегионыService catalogБизнесРегионыService,
        //ICatalogВидыДеятельностиService catalogВидыДеятельностиService,
        ICatalogГруппыПользователейService catalogГруппыПользователейService,
        ICatalogВидыНоменклатурыService catalogВидыНоменклатурыService,
        ICatalogВидыЦенService catalogВидыЦенService,
        ICatalogЗначенияСвойствОбъектовService catalogЗначенияСвойствОбъектовService,
        //ICatalogИсточникиЗаявокService catalogИсточникиЗаявокService,
        ICatalogМаркиService catalogМаркиService,
        ICatalogНоменклатураService catalogНоменклатураService,
        ICatalogПартнерыService catalogПартнерыService,
        ICatalogПартнерыVipService catalogПартнерыVipService,
        ICatalogПодвидыНоменклатурыService catalogПодвидыНоменклатурыService,
        ICatalogПользователиService catalogПользователиService,
        ICatalogПричиныОтменыЗаказовКлиентовService catalogПричиныОтменыЗаказовКлиентовService,
        ICatalogПроизводителиService catalogПроизводителиService,
        ICatalogСкладыService catalogСкладыService,
        ICatalogСоглашенияСКлиентамиService catalogСоглашенияСКлиентамиService,
        ICatalogСтруктураПредприятияService catalogСтруктураПредприятияService,
        //ICatalogСхемаПредприятияService catalogСхемаПредприятияService,
        ICatalogУпаковкиЕдиницыИзмеренияService catalogУпаковкиЕдиницыИзмеренияService,
        ICatalogЦеновыеГруппыService catalogЦеновыеГруппыService,
        ICatalogТэгиПартнеровService catalogТэгиПартнеровService,
        IInformationRegisterТэгиПартнеровService informationRegisterТэгиПартнеров,
        CurrencyService currencyService) : ICatalogsAllService
        // Wms
        //ICatalogЯчейкиService catalogЯчейкиService
    {
        //private readonly ILogger<CatalogsAllService> _logger = logger;
        private readonly ICatalogБизнесРегионыService _catalogБизнесРегионыService = catalogБизнесРегионыService;
        //private readonly ICatalogВидыДеятельностиService _catalogВидыДеятельностиService = catalogВидыДеятельностиService;
        private readonly ICatalogГруппыПользователейService _catalogГруппыПользователейService = catalogГруппыПользователейService;
        private readonly ICatalogВидыНоменклатурыService _catalogВидыНоменклатурыService = catalogВидыНоменклатурыService;
        private readonly ICatalogВидыЦенService _catalogВидыЦенService = catalogВидыЦенService;
        private readonly ICatalogЗначенияСвойствОбъектовService _catalogЗначенияСвойствОбъектовService = catalogЗначенияСвойствОбъектовService;
        //private readonly ICatalogИсточникиЗаявокService _catalogИсточникиЗаявокService = catalogИсточникиЗаявокService;
        private readonly ICatalogМаркиService _catalogМаркиService = catalogМаркиService;
        private readonly ICatalogНоменклатураService _catalogНоменклатураService = catalogНоменклатураService;
        private readonly ICatalogПартнерыService _catalogПартнерыService = catalogПартнерыService;
        private readonly ICatalogПартнерыVipService _catalogПартнерыVipService = catalogПартнерыVipService;
        private readonly ICatalogПодвидыНоменклатурыService _catalogПодвидыНоменклатурыService = catalogПодвидыНоменклатурыService;
        private readonly ICatalogПользователиService _catalogПользователиService = catalogПользователиService;
        private readonly ICatalogПричиныОтменыЗаказовКлиентовService _catalogПричиныОтменыЗаказовКлиентовService = catalogПричиныОтменыЗаказовКлиентовService;
        private readonly ICatalogПроизводителиService _catalogПроизводителиService = catalogПроизводителиService;
        private readonly ICatalogСкладыService _catalogСкладыService = catalogСкладыService;
        private readonly ICatalogСоглашенияСКлиентамиService _catalogСоглашенияСКлиентамиService = catalogСоглашенияСКлиентамиService;
        private readonly ICatalogСтруктураПредприятияService _catalogСтруктураПредприятияService = catalogСтруктураПредприятияService;
        //private readonly ICatalogСхемаПредприятияService _catalogСхемаПредприятияService = catalogСхемаПредприятияService;
        private readonly ICatalogУпаковкиЕдиницыИзмеренияService _catalogУпаковкиЕдиницыИзмеренияService = catalogУпаковкиЕдиницыИзмеренияService;
        private readonly ICatalogЦеновыеГруппыService _catalogЦеновыеГруппыService = catalogЦеновыеГруппыService;
        private readonly ICatalogТэгиПартнеровService _catalogТэгиПартнеровService = catalogТэгиПартнеровService;
        private readonly IInformationRegisterТэгиПартнеровService _informationRegisterТэгиПартнеров = informationRegisterТэгиПартнеров;
        private readonly CurrencyService _currencyService = currencyService;
        // Wms
        //private readonly ICatalogЯчейкиService _catalogЯчейкиService = catalogЯчейкиService;


        public async Task<List<ServiceResult>> LoadingAsync()
        {
            var result = new List<ServiceResult>
            {
                await _catalogБизнесРегионыService.LoadingAsync(),
                //await _catalogВидыДеятельностиService.LoadingAsync(), // нет
                await _catalogГруппыПользователейService.LoadingAsync(),
                await _catalogВидыНоменклатурыService.LoadingAsync(),
                await _catalogВидыЦенService.LoadingAsync(),
                await _catalogЗначенияСвойствОбъектовService.LoadingAsync(),
                //await _catalogИсточникиЗаявокService.LoadingAsync(), // нет
                await _catalogМаркиService.LoadingAsync(),            // пустой
                await _catalogНоменклатураService.LoadingAsync(),
                await _catalogПартнерыService.LoadingAsync(),           // нет ссылок на Доброга_ЕмкостьПотенциальная
                await _catalogПартнерыVipService.LoadingAsync(),      // пустой
                await _catalogПодвидыНоменклатурыService.LoadingAsync(),
                await _catalogПользователиService.LoadingAsync(),       // нет ссылок на Доброга_СхемаПредприятия_Key, Доброга_Должность
                await _catalogПричиныОтменыЗаказовКлиентовService.LoadingAsync(),
                await _catalogПроизводителиService.LoadingAsync(),
                await _catalogСкладыService.LoadingAsync(),
                await _catalogСоглашенияСКлиентамиService.LoadingAsync(),
                await _catalogСтруктураПредприятияService.LoadingAsync(),
                //await _catalogСхемаПредприятияService.LoadingAsync(), // нет
                await _catalogУпаковкиЕдиницыИзмеренияService.LoadingAsync(),
                await _catalogЦеновыеГруппыService.LoadingAsync(),
                await _catalogТэгиПартнеровService.LoadingAsync(),
                await _informationRegisterТэгиПартнеров.LoadingAsync(),
                await _currencyService.FetchAndStoreRatesAsync(null, null, null)
                // Wms
                //await _catalogЯчейкиService.LoadingAsync()
            };

            return result;
        }
    }
}
