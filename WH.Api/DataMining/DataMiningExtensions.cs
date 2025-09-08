using System.Net.Http.Headers;
using System.Net.Mime;

namespace WH.Api.DataMining
{
    public static class DataMiningExtensions
    {
        public static IServiceCollection AddDataMining(this IServiceCollection services, IConfiguration configuration)
        {

            DataMiningClientConfiguration config = configuration.GetSection(DataMiningClientConfiguration.Section).Get<DataMiningClientConfiguration>()
                ?? throw new ApplicationException("DataMiningConfig not found");

            services.AddHttpClient<IDataMiningClient, DataMiningClient>(options =>
            {
                options.BaseAddress = new Uri(config.BaseAddress);
                options.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json));
            });

            services.AddScoped<IDataMiningService, DataMiningService>();

            return services;
        }
    }
}
