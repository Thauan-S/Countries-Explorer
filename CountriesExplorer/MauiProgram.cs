using CountriesExplorer.ViewModels;
using Domain.Services;
using Infrastructure.Services;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Polly.Extensions.Http;
using Polly;

namespace CountriesExplorer
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder.UseMauiApp<App>().ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            }).UseMauiCommunityToolkit();

            builder.Services.AddHttpClient<ICountriesService, CountriesService>(client =>
            {
                client.BaseAddress = new Uri("https://restcountries.com/v3.1/");
            })
            .AddPolicyHandler(GetRetryPolicy())
            .AddPolicyHandler(GetCircuitBreakerPolicy());

            static IAsyncPolicy<HttpResponseMessage> GetRetryPolicy()
            {
                return HttpPolicyExtensions
                    .HandleTransientHttpError() 
                    .WaitAndRetryAsync(
                        3,
                        retryAttempt => TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)) 
                    );
            }
            static IAsyncPolicy<HttpResponseMessage> GetCircuitBreakerPolicy()
            {
                return HttpPolicyExtensions
                    .HandleTransientHttpError()
                    .CircuitBreakerAsync(
                        5,
                        TimeSpan.FromSeconds(30)
                    );
            }
            builder.Services.AddTransient<CountryViewModel>();
            builder.Services.AddTransient<MainPage>();
#if DEBUG
            builder.Logging.AddDebug();
#endif
            return builder.Build();
        }
    }
}