using Strategy.Interfaces;

namespace Strategy.Services
{
    internal class RedactionService : IRedactionService
    {
        private IPhotoStrategy? _strategy;

        public void SetStrategy(IPhotoStrategy strategy)
        {
            _strategy = strategy;
        }

        public async Task<List<string>> GetPhotosAsync(string category)
        {
            if (_strategy == null)
                return new List<string>();

            return await _strategy.FindPhotosAsync(category);
        }
    }
}