using Microsoft.Extensions.Configuration;
using Strategy.Interfaces;
using Strategy.Responses;

namespace Strategy.PhotoStrategies
{
    internal class PexelsStrategy(IConfiguration configuration, ICallApiService callApiService) : IPhotoStrategy
    {
        private readonly string _apiKey = configuration["PexelsApiKey"]!;
        private readonly string _baseUrl = configuration["PexelsBaseUrl"]!;

        public async Task<List<string>> FindPhotosAsync(string category)
        {
            var client = CreateHttpClient();
            var response = await callApiService.GetAsync<PexelsResponse>(client, $"search?query={category}&per_page=5&size=small");

            return response?.photos.Select(p => p.url).ToList() ?? new List<string>();
        }

        private HttpClient CreateHttpClient()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(_baseUrl);
            client.DefaultRequestHeaders.Add("Authorization", _apiKey);
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }
    }
}
