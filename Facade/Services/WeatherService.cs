using Facade.Interfaces;
using Facade.ViewModels;

namespace Facade.Services
{
    internal class WeatherService(ICallApiService callApiService) : IWeatherService
    {
        public async Task<WeatherInfo?> GetWeatherAsync(string city)
        {
            var response = await callApiService.GetAsync<WeatherInfo>($"q={city}&units=metric");

            return response;
        }
    }
}
