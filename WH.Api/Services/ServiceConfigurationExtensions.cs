using WH.Api.Services.AccumulationRegister;
using WH.Api.Services.Awesome;
using WH.Api.Services.Catalog;
using WH.Api.Services.Document;
using WH.Api.Services.InformationRegister;
using WH.Api.Services.Trash;
using WH.Api.Services.Wms;

namespace WH.Api.Services
{
    public static class ServiceConfigurationExtensions
    {
        public static IServiceCollection AddAppServices(this IServiceCollection services)
        {
            services.AddScoped<IAllService, AllService>();
            // AccumulationRegister
            services.AddScoped<IAccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeService, AccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeService>();
            services.AddScoped<IAccumulationRegisterВыручкаИСебестоимостьПродажTurnoversService, AccumulationRegisterВыручкаИСебестоимостьПродажTurnoversService>();
            services.AddScoped<IAccumulationRegisterГрафикПоступленияТоваровRecordTypeService, AccumulationRegisterГрафикПоступленияТоваровRecordTypeService>();
            services.AddScoped<IAccumulationRegisterЗакупкиRecordTypeService, AccumulationRegisterЗакупкиRecordTypeService>();
            services.AddScoped<IAccumulationRegisterСебестоимостьТоваровBalanceService, AccumulationRegisterСебестоимостьТоваровBalanceService>();
            services.AddScoped<IAccumulationRegisterСебестоимостьТоваровBalanceAndTurnoversService, AccumulationRegisterСебестоимостьТоваровBalanceAndTurnoversService>();
            services.AddScoped<IAccumulationRegisterСебестоимостьТоваровRecordTypeService, AccumulationRegisterСебестоимостьТоваровRecordTypeService>();
            services.AddScoped<IAccumulationRegisterТоварыНаСкладахBalanceAndTurnoversService, AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversService>();
            services.AddScoped<IAccumulationRegisterТоварыНаСкладахBalanceService, AccumulationRegisterТоварыНаСкладахBalanceService>();
            services.AddScoped<IAccumulationRegisterТоварыНаСкладахRecordTypeService, AccumulationRegisterТоварыНаСкладахRecordTypeService>();

            // Catalog 
            services.AddScoped<ICatalogsAllService, CatalogsAllService>();
            services.AddScoped<ICatalogБизнесРегионыService, CatalogБизнесРегионыService>();
            services.AddScoped<ICatalogВидыДеятельностиService, CatalogВидыДеятельностиService>();
            services.AddScoped<ICatalogГруппыПользователейService, CatalogГруппыПользователейService>();
            services.AddScoped<ICatalogВидыНоменклатурыService, CatalogВидыНоменклатурыService>();
            services.AddScoped<ICatalogВидыЦенService, CatalogВидыЦенService>();
            services.AddScoped<ICatalogЗначенияСвойствОбъектовService, CatalogЗначенияСвойствОбъектовService>();
            services.AddScoped<ICatalogИсточникиЗаявокService, CatalogИсточникиЗаявокService>();
            services.AddScoped<ICatalogМаркиService, CatalogМаркиService>();
            services.AddScoped<ICatalogНоменклатураService, CatalogНоменклатураService>();
            services.AddScoped<ICatalogПартнерыService, CatalogПартнерыService>();
            services.AddScoped<ICatalogПартнерыVipService, CatalogПартнерыVipService>();
            services.AddScoped<ICatalogПодвидыНоменклатурыService, CatalogПодвидыНоменклатурыService>();
            services.AddScoped<ICatalogПользователиService, CatalogПользователиService>();
            services.AddScoped<ICatalogПричиныОтменыЗаказовКлиентовService, CatalogПричиныОтменыЗаказовКлиентовService>();
            services.AddScoped<ICatalogПроизводителиService, CatalogПроизводителиService>();
            services.AddScoped<ICatalogСоглашенияСКлиентамиService, CatalogСоглашенияСКлиентамиService>();
            services.AddScoped<ICatalogСкладыService, CatalogСкладыService>();
            services.AddScoped<ICatalogСтруктураПредприятияService, CatalogСтруктураПредприятияService>();
            services.AddScoped<ICatalogСхемаПредприятияService, CatalogСхемаПредприятияService>();
            services.AddScoped<ICatalogТэгиПартнеровService, CatalogТэгиПартнеровService>();
            services.AddScoped<ICatalogУпаковкиЕдиницыИзмеренияService, CatalogУпаковкиЕдиницыИзмеренияService>();
            services.AddScoped<ICatalogЦеновыеГруппыService, CatalogЦеновыеГруппыService>();

            // Document
            services.AddScoped<IDocumentsAllService, DocumentsAllService>();
            services.AddScoped<IDocumentАктОРасхожденияхПослеОтгрузкиService, DocumentАктОРасхожденияхПослеОтгрузкиService>();
            services.AddScoped<IDocumentВозвратТоваровОтКлиентаService, DocumentВозвратТоваровОтКлиентаService>();
            services.AddScoped<IDocumentЗаказКлиентаService, DocumentЗаказКлиентаService>();
            services.AddScoped<IDocumentЗаказНаПеремещениеService, DocumentЗаказНаПеремещениеService>();
            services.AddScoped<IDocumentОприходованиеИзлишковТоваровService, DocumentОприходованиеИзлишковТоваровService>();
            services.AddScoped<IDocumentОтчетОРозничныхПродажахService, DocumentОтчетОРозничныхПродажахService>();
            services.AddScoped<IDocumentПриходныйОрдерНаТоварыService, DocumentПриходныйОрдерНаТоварыService>();
            services.AddScoped<IDocumentПриобретениеТоваровУслугService, DocumentПриобретениеТоваровУслугService>();
            services.AddScoped<IDocumentРасходныйОрдерНаТоварыService, DocumentРасходныйОрдерНаТоварыService>();
            services.AddScoped<IDocumentРеализацияТоваровУслугService, DocumentРеализацияТоваровУслугService>();
            services.AddScoped<IDocumentСборкаТоваровService, DocumentСборкаТоваровService>();
            services.AddScoped<IDocumentУстановкаЦенНоменклатурыService, DocumentУстановкаЦенНоменклатурыService>();


            // InformationRegister 
            services.AddScoped<IInformationRegisterТэгиПартнеровService, InformationRegisterТэгиПартнеровService>();
            services.AddScoped<IInformationRegisterЦеныНоменклатурыRecordTypeService, InformationRegisterЦеныНоменклатурыRecordTypeService>();
            services.AddScoped<IInformationRegisterЦеныНоменклатурыЗакупочныеSliceLastService, InformationRegisterЦеныНоменклатурыЗакупочныеSliceLastService>();
            services.AddScoped<IInformationRegisterЦеныНоменклатурыПоставкиSliceLastService, InformationRegisterЦеныНоменклатурыПоставкиSliceLastService>();

            // Wms
            services.AddScoped<IAccumulationRegisterТоварыВЯчейкахBalanceAndTurnoversService, AccumulationRegisterТоварыВЯчейкахBalanceAndTurnoversService>();
            services.AddScoped<ICatalogЯчейкиService, CatalogЯчейкиService>();

            // Awesome
            services.AddScoped<IAwesomeТоварыНаСкладахRecordTypeОперацияЦеныService, AwesomeТоварыНаСкладахRecordTypeОперацияЦеныService>();

            services.AddScoped<CurrencyService>();

            return services;
        }

        public static IServiceCollection ConfigureAppParameters(this IServiceCollection services)
        {
            return services;
        }
    }
}
