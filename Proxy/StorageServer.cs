namespace Proxy
{
    internal class StorageServer : IStorageServer
    {
        private List<StorageObject> _storageObjects = new List<StorageObject>();

        public void AddObject(StorageObject storageObject)
        {
            _storageObjects.Add(storageObject);
        }

        public void Download(StorageObject storageObject)
        {
            Console.WriteLine("Download started...");
            Console.WriteLine($"Name : {storageObject.Name}");
            Console.WriteLine($"Path : {storageObject.Path}");
            Console.WriteLine($"Type : {storageObject.Type}");
            Console.WriteLine("Content:");
            Console.WriteLine(storageObject.Content);
            Console.WriteLine("Download finished.");
        }

        public List<StorageObject> GetObjects()
        {
            return _storageObjects;
        }
    }
}
