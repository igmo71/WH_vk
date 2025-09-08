namespace WH.Api.OData.ODataParameters.AccumulationRegister
{
    public interface IAccumulationRegisterВыручкаИСебестоимостьПродажTurnoversParameters : IODataParameters
    {
        string GetСуммаВыручкиTurnoverUri(DateTime date);
    }

    public class AccumulationRegisterВыручкаИСебестоимостьПродажTurnoversParameters : IAccumulationRegisterВыручкаИСебестоимостьПродажTurnoversParameters
    {
        public int? Top => throw new NotImplementedException();

        public string GetCountUri(DateTime? begin = null, DateTime? end = null)
        {
            string uri = $"AccumulationRegister_ВыручкаИСебестоимостьПродаж" +
                         $"/Turnovers(StartPeriod=datetime'{begin:s}',EndPeriod=datetime'{((DateTime)end!).AddSeconds(-1):s}')/$count";
            return uri;
        }

        public string GetUri(DateTime? begin = null, DateTime? end = null, int? iteration = null)
        {
            string uri = $"AccumulationRegister_ВыручкаИСебестоимостьПродаж" +
                         $"/Turnovers(StartPeriod=datetime'{begin:s}',EndPeriod=datetime'{((DateTime)end!).AddSeconds(-1):s}')" +
                          "?$expand=АналитикаУчетаНоменклатуры,АналитикаУчетаПоПартнерам" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }

        public string GetСуммаВыручкиTurnoverUri(DateTime date)
        {
            string uri = $"AccumulationRegister_ВыручкаИСебестоимостьПродаж" +
                         $"/Turnovers(StartPeriod=datetime'{date:s}',EndPeriod=datetime'{date.AddDays(1).AddSeconds(-1):s}')" +
                          "?$select=СуммаВыручкиTurnover" +
                          "&$format=json" +
                          "&$inlinecount=allpages";
            return uri;
        }
    }
}
