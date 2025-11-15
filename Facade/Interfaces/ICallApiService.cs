namespace Facade.Interfaces
{
    internal interface ICallApiService
    {
        Task<T?> GetAsync<T>(string apiUrl);
    }
}
