using Proxy;

var server = new StorageServerProxy("qwerty123");
server.AddObject(new PublicStorageObject
{
    Name = "PublicFile.txt",
    Path = "/public/PublicFile.txt",
    Content = "This is a public file.",
    Type = StorageObjectType.File
});
server.AddObject(new RestrictedStorageObject
{
    Name = "RestrictedFile.txt",
    Path = "/restricted/RestrictedFile.txt",
    Content = "This is a restricted file.",
    Type = StorageObjectType.File
});

Console.Write("Please enter password to authenticate (leave empty to skip): ");
var password = Console.ReadLine() ?? string.Empty;

if (!string.IsNullOrWhiteSpace(password))
{
    server.Authenticate(password);
    Console.WriteLine("Authentication successful.");
}
else
{
    Console.WriteLine("Skipping authentication.");
}

Console.WriteLine("Available storage objects:");
var objects = server.GetObjects();
for (int i = 0; i < objects.Count; i++)
{
    var o = objects[i];
    var kind = o is RestrictedStorageObject ? "Restricted" : "Public";
    Console.WriteLine($"{i + 1}. {o.Name} ({kind}) - {o.Path}");
}
Console.WriteLine();
Console.Write("Select object to download (number): ");
var selection = Console.ReadLine();

if (!int.TryParse(selection, out var sel) || sel < 0 || sel > objects.Count)
{
    Console.WriteLine("Invalid selection.");
    return;
}

var selectedObject = objects[sel - 1];
try
{
    server.Download(selectedObject);
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
Console.WriteLine("Program finished.");
Console.ReadKey();

