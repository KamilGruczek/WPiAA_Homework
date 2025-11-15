using System.Net.Http.Json;
using Facade.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Facade.Services
{
    internal class CallApiService(IConfiguration configuration) : ICallApiService
    {
        public async Task<T?> GetAsync<T>(string apiUrl)
        {
            try
            {
                var client = CreateHttpClient();
                var newUrl = GetUrl(apiUrl);
                var response = await client.GetAsync(newUrl);
                response.EnsureSuccessStatusCode();
                var str = await response.Content.ReadAsStringAsync();

                return await response.Content.ReadFromJsonAsync<T>();
            }
            catch (Exception)
            {
                Console.WriteLine("I'm sorry, an error occurred while processing your request. Please try again.");
                return default;
            }
        }

        private HttpClient CreateHttpClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(configuration["APIs:WeatherAPIUrl"]!);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        private string GetUrl(string apiUrl)
        {
            return $"?appid={configuration["APIs:WeatherAPIKey"]}&{apiUrl}";
        }
    }
}
