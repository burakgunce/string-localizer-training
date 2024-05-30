using Microsoft.AspNetCore.Localization;
using System.Globalization;

namespace StringLocalizer.Extensions
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddMVCServices(this IServiceCollection services)
        {
            services.AddLocalization(options => options.ResourcesPath = "Resources");
            services.Configure<RequestLocalizationOptions>(opt =>
            {
                var supCultures = new List<CultureInfo>()
                {
                    new CultureInfo("en"),
                    new CultureInfo("tr"),
                };
                opt.DefaultRequestCulture = new RequestCulture("tr");
                opt.SupportedUICultures = supCultures;
            });

            return services;
        }
    }
}
