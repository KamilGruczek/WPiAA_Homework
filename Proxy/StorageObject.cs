namespace Proxy
{
    internal class StorageObject
    {
        public required string Name { get; set; }
        public required string Path { get; set; }
        public required string Content { get; set; }
        public required StorageObjectType Type { get; set; }
    }
}
