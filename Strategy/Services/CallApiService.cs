using System.Diagnostics;
using System.Net.Http.Json;
using Strategy.Interfaces;

namespace Strategy.Services
{
    internal class CallApiService : ICallApiService
    {
        public async Task<T?> GetAsync<T>(HttpClient client, string apiUrl)
        {
            try
            {
                var response = await client.GetAsync(apiUrl);

                response.EnsureSuccessStatusCode();

                return await response.Content.ReadFromJsonAsync<T>();
            }
            catch (Exception ex)
            {
                Debug.Fail(ex.Message);
                Console.WriteLine("I'm sorry, an error occurred while processing your request. Please try again.");
                return default;
            }
        }
    }
}
