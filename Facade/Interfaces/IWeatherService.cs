using Facade.ViewModels;

namespace Facade.Interfaces
{
    internal interface IWeatherService
    {
        Task<WeatherInfo?> GetWeatherAsync(string city);
    }
}
