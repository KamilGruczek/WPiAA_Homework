
namespace Proxy
{
    internal class StorageServerProxy : IStorageServer
    {
        private readonly StorageServer _storageServer;
        private readonly string _masterPassword;
        private bool _isAuthenticated = false;

        public StorageServerProxy(string masterPassword)
        {
            _storageServer = new StorageServer();
            _masterPassword = masterPassword;
        }

        public void AddObject(StorageObject storageObject)
        {
            _storageServer.AddObject(storageObject);
        }

        public void Download(StorageObject storageObject)
        {
            if (storageObject is RestrictedStorageObject)
            {
                if (!_isAuthenticated)
                {
                    throw new UnauthorizedAccessException("Access is denied!");
                }
            }
            else if (storageObject is not PublicStorageObject)
            {
                throw new InvalidOperationException("Unknown storage object type!");
            }

            _storageServer.Download(storageObject);
        }

        public void Authenticate(string password)
        {
            if (password == _masterPassword)
            {
                _isAuthenticated = true;
            }
        }

        public List<StorageObject> GetObjects()
        {
            return _storageServer.GetObjects();
        }
    }
}
