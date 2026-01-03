using Microsoft.Extensions.Configuration;
using Strategy.Interfaces;
using Strategy.Responses;

namespace Strategy.PhotoStrategies
{
    internal class PixabayStrategy(IConfiguration configuration, ICallApiService callApiService) : IPhotoStrategy
    {
        private readonly string _apiKey = configuration["PixabayApiKey"]!;
        private readonly string _baseUrl = configuration["PixabayBaseUrl"]!;

        public async Task<List<string>> FindPhotosAsync(string category)
        {
            var client = CreateHttpClient();
            var response = await callApiService.GetAsync<PixabayResponse>(client, $"?key={_apiKey}&category={category}&image_type=all&per_page=5");

            return response?.hits.Select(p => p.webformatURL).ToList() ?? new List<string>();
        }

        private HttpClient CreateHttpClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(_baseUrl);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }
    }
}
