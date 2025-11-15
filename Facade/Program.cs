using Facade.Interfaces;
using Facade.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration(o => o.AddJsonFile("appSettings.json", false, false))
.ConfigureServices((_, services) =>
{
    services.AddTransient<ICallApiService, CallApiService>();
    services.AddTransient<IWeatherService, WeatherService>();
    services.AddSingleton<Application>();
})
.Build();

var app = host.Services.GetRequiredService<Application>();
await app.RunAsync();

internal class Application(IWeatherService weatherService)
{
    public async Task RunAsync()
    {
        Console.WriteLine("Hello in Fasade Weather App.");
        Console.WriteLine("Enter city name to get weather info:");
        var city = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(city))
        {
            Console.WriteLine("City name cannot be empty.");
            Console.ReadKey();
            return;
        }

        var weatherInfo = weatherService.GetWeatherAsync(city).Result;
        if (weatherInfo == null)
        {
            Console.WriteLine("Could not retrieve weather information. Please check the city name and try again.");
            Console.ReadKey();
            return;
        }

        Console.WriteLine($"Weather in {city}: {weatherInfo.Weather[0].Description}, Temperature: {weatherInfo.Main.Temp}°C");
        Console.WriteLine("Have a beautiful day!");
        Console.ReadKey();
    }
}