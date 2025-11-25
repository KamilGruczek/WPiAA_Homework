namespace Proxy
{
    internal interface IStorageServer
    {
        void AddObject(StorageObject storageObject);
        List<StorageObject> GetObjects();
        void Download(StorageObject storageObject);
    }
}
