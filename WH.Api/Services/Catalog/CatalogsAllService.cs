namespace WH.Api.Services.Catalog
{
    public interface ICatalogsAllService
    {
        Task<List<ServiceResult>> LoadingAsync();
    }

    public class CatalogsAllService(
        ICatalogБизнесРегионыService catalogБизнесРегионыService,
        ICatalogГруппыПользователейService catalogГруппыПользователейService,
        ICatalogВидыНоменклатурыService catalogВидыНоменклатурыService,
        ICatalogВидыЦенService catalogВидыЦенService,
        ICatalogЗначенияСвойствОбъектовService catalogЗначенияСвойствОбъектовService,
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
        ICatalogУпаковкиЕдиницыИзмеренияService catalogУпаковкиЕдиницыИзмеренияService,
        ICatalogЦеновыеГруппыService catalogЦеновыеГруппыService,
        CurrencyService currencyService) : ICatalogsAllService
    {
        private readonly ICatalogБизнесРегионыService _catalogБизнесРегионыService = catalogБизнесРегионыService;
        private readonly ICatalogГруппыПользователейService _catalogГруппыПользователейService = catalogГруппыПользователейService;
        private readonly ICatalogВидыНоменклатурыService _catalogВидыНоменклатурыService = catalogВидыНоменклатурыService;
        private readonly ICatalogВидыЦенService _catalogВидыЦенService = catalogВидыЦенService;
        private readonly ICatalogЗначенияСвойствОбъектовService _catalogЗначенияСвойствОбъектовService = catalogЗначенияСвойствОбъектовService;
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
        private readonly ICatalogУпаковкиЕдиницыИзмеренияService _catalogУпаковкиЕдиницыИзмеренияService = catalogУпаковкиЕдиницыИзмеренияService;
        private readonly ICatalogЦеновыеГруппыService _catalogЦеновыеГруппыService = catalogЦеновыеГруппыService;
        private readonly CurrencyService _currencyService = currencyService;

        public async Task<List<ServiceResult>> LoadingAsync()
        {
            var result = new List<ServiceResult>
            {
                await _catalogБизнесРегионыService.LoadingAsync(),
                await _catalogГруппыПользователейService.LoadingAsync(),
                await _catalogВидыНоменклатурыService.LoadingAsync(),
                await _catalogВидыЦенService.LoadingAsync(),
                await _catalogЗначенияСвойствОбъектовService.LoadingAsync(),
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
                await _catalogУпаковкиЕдиницыИзмеренияService.LoadingAsync(),
                await _catalogЦеновыеГруппыService.LoadingAsync(),
                await _currencyService.FetchAndStoreRatesAsync(null, null, null)
                };

            return result;
        }
    }
}
