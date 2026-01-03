namespace Strategy.Interfaces
{
    internal interface IPhotoStrategy
    {
        public Task<List<string>> FindPhotosAsync(string category);
    }
}
