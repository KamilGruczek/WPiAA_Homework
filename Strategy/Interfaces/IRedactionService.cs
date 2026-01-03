namespace Strategy.Interfaces
{
    internal interface IRedactionService
    {
        Task<List<string>> GetPhotosAsync(string category);
        void SetStrategy(IPhotoStrategy strategy);
    }
}
