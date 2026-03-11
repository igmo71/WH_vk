using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;
using WH.Api.OData.ODataParameters.AccumulationRegister;
using WH.Api.OData.ODataParameters.Catalog;
using WH.Api.OData.ODataParameters.Document;
using WH.Api.OData.ODataParameters.InformationRegister;

namespace WH.Api.OData
{
    public static class ODataConfigurationExtensions
    {
        public static IServiceCollection AddODataParameters(this IServiceCollection services)
        {
            services.AddSingleton<IAccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeParameters, AccumulationRegisterВыручкаИСебестоимостьПродажRecordTypeParameters>();
            services.AddSingleton<IAccumulationRegisterВыручкаИСебестоимостьПродажTurnoversParameters, AccumulationRegisterВыручкаИСебестоимостьПродажTurnoversParameters>();
            services.AddSingleton<IAccumulationRegisterГрафикПоступленияТоваровRecordTypeParameters, AccumulationRegisterГрафикПоступленияТоваровRecordTypeParameters>();
            services.AddSingleton<IAccumulationRegisterЗакупкиRecordTypeParameters, AccumulationRegisterЗакупкиRecordTypeParameters>();
            services.AddSingleton<IAccumulationRegisterТоварыНаСкладахBalanceParameters, AccumulationRegisterТоварыНаСкладахBalanceParameters>();
            services.AddSingleton<IAccumulationRegisterТоварыНаСкладахBalanceAndTurnoversParameters, AccumulationRegisterТоварыНаСкладахBalanceAndTurnoversParameters>();
            services.AddSingleton<IAccumulationRegisterТоварыНаСкладахRecordTypeParameters, AccumulationRegisterТоварыНаСкладахRecordTypeParameters>();

            services.AddSingleton<ICatalogГруппыПользователейParameters, CatalogГруппыПользователейParameters>();
            services.AddSingleton<ICatalogБизнесРегионыParameters, CatalogБизнесРегионыParameters>();
            services.AddSingleton<ICatalogВидыНоменклатурыParameters, CatalogВидыНоменклатурыParameters>();
            services.AddSingleton<ICatalogВидыЦенParameters, CatalogВидыЦенParameters>();
            services.AddSingleton<ICatalogЗначенияСвойствОбъектовParameters, CatalogЗначенияСвойствОбъектовParameters>();
            services.AddSingleton<ICatalogКонтрагентыParameters, CatalogКонтрагентыParameters>();
            services.AddSingleton<ICatalogМаркиParameters, CatalogМаркиParameters>();
            services.AddSingleton<ICatalogНоменклатураParameters, CatalogНоменклатураParameters>();
            services.AddSingleton<ICatalogПартнерыParameters, CatalogПартнерыParameters>();
            services.AddSingleton<ICatalogПартнерыVipParameters, CatalogПартнерыVipParameters>();
            services.AddSingleton<ICatalogПодвидыНоменклатурыParameters, CatalogПодвидыНоменклатурыParameters>();
            services.AddSingleton<ICatalogПользователиParameters, CatalogПользователиParameters>();
            services.AddSingleton<ICatalogПричиныОтменыЗаказовКлиентовParameters, CatalogПричиныОтменыЗаказовКлиентовParameters>();
            services.AddSingleton<ICatalogПроизводителиParameters, CatalogПроизводителиParameters>();
            services.AddSingleton<ICatalogСкладыParameters, CatalogСкладыParameters>();
            services.AddSingleton<ICatalogСоглашенияСКлиентамиParameters, CatalogСоглашенияСКлиентамиParameters>();
            services.AddSingleton<ICatalogСтруктураПредприятияParameters, CatalogСтруктураПредприятияParameters>();
            services.AddSingleton<ICatalogТэгиПартнеровParameters, CatalogТэгиПартнеровParameters>();
            services.AddSingleton<ICatalogУпаковкиЕдиницыИзмеренияParameters, CatalogУпаковкиЕдиницыИзмеренияParameters>();
            services.AddSingleton<ICatalogЦеновыеГруппыParameters, CatalogЦеновыеГруппыParameters>();

            services.AddSingleton<IDocumentАктОРасхожденияхПослеОтгрузкиParameters, DocumentАктОРасхожденияхПослеОтгрузкиParameters>();
            services.AddSingleton<IDocumentВозвратТоваровОтКлиентаParameters, DocumentВозвратТоваровОтКлиентаParameters>();
            services.AddSingleton<IDocumentЗаказКлиентаParameters, DocumentЗаказКлиентаParameters>();
            services.AddSingleton<IDocumentЗаказНаПеремещениеParameters, DocumentЗаказНаПеремещениеParameters>();
            services.AddSingleton<IDocumentОприходованиеИзлишковТоваровParameters, DocumentОприходованиеИзлишковТоваровParameters>();
            services.AddSingleton<IDocumentОтчетОРозничныхПродажахParameters, DocumentОтчетОРозничныхПродажахParameters>();
            services.AddSingleton<IDocumentПриобретениеТоваровУслугParameters, DocumentПриобретениеТоваровУслугParameters>();
            services.AddSingleton<IDocumentПриходныйОрдерНаТоварыParameters, DocumentПриходныйОрдерНаТоварыParameters>();
            services.AddSingleton<IDocumentРасходныйОрдерНаТоварыParameters, DocumentРасходныйОрдерНаТоварыParameters>();
            services.AddSingleton<IDocumentРеализацияТоваровУслугParameters, DocumentРеализацияТоваровУслугParameters>();
            services.AddSingleton<IDocumentСборкаТоваровParameters, DocumentСборкаТоваровParameters>();
            services.AddSingleton<IDocumentУстановкаЦенНоменклатурыParameters, DocumentУстановкаЦенНоменклатурыParameters>();

            services.AddSingleton<IInformationRegisterТэгиПартнеровParameters, InformationRegisterТэгиПартнеровParameters>();
            services.AddSingleton<IInformationRegisterЦеныНоменклатурыRecordTypeParameters, InformationRegisterЦеныНоменклатурыRecordTypeParameters>();
            services.AddSingleton<IInformationRegisterЦеныНоменклатурыЗакупочныеSliceLastParameters, InformationRegisterЦеныНоменклатурыЗакупочныеSliceLastParameters>();
            services.AddSingleton<IInformationRegisterЦеныНоменклатурыПоставкиSliceLastParameters, InformationRegisterЦеныНоменклатурыПоставкиSliceLastParameters>();

            return services;
        }

        public static IServiceCollection AddODataClient(this IServiceCollection services, IConfiguration configuration)
        {

            ODataClientConfig oDataClientConfig = configuration.GetSection(ODataClientConfig.Section).Get<ODataClientConfig>()
                ?? throw new ApplicationException("ODataClient Config not found");

            services.AddHttpClient<IODataClient, ODataClient>(options =>
            {
                options.BaseAddress = new Uri(oDataClientConfig.BaseAddress);
                options.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json));
                options.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                    "Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{oDataClientConfig.Username}:{oDataClientConfig.Password}")));
            });

            return services;
        }       
    }
}
