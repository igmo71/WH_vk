using System.Net.Http.Headers;
using System.Net.Mime;
using System.Text;

namespace WH.Api.Voximplant
{
    public static class VoximplantExtensions
    {
        public static IServiceCollection AddVoximplant(this IServiceCollection services, IConfiguration configuration)
        {
            VoximplantClientConfig voximplantClientConfig = configuration.GetSection(VoximplantClientConfig.Section).Get<VoximplantClientConfig>()
                ?? throw new ApplicationException("VoximplantClient Config not found");

            services.AddHttpClient<IVoximplantClient, VoximplantClient>(options =>
            {
                options.BaseAddress = new Uri(voximplantClientConfig.BaseAddress);
                options.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue(MediaTypeNames.Application.Json));
                options.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(
                    "Basic", Convert.ToBase64String(Encoding.UTF8.GetBytes($"{voximplantClientConfig.Username}:{voximplantClientConfig.Password}")));
            });

            services.AddScoped<IVoximplantParameters, VoximplantParameters>();
            services.AddScoped<IVoximplantService, VoximplantService>();

            return services;
        }
    }
}
