namespace Strategy.Interfaces
{
    internal interface ICallApiService
    {
        Task<T?> GetAsync<T>(HttpClient client, string apiUrl);
    }
}
