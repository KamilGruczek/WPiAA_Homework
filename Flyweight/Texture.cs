namespace Flyweight
{
    internal class Texture
    {
        public string Name { get; set; }
        public string Path { get; set; }

        public Texture(string name, string path)
        {
            Name = name;
            Path = path;
            Console.WriteLine($"Loading texture from path: {Path}");
        }

        public void Render(int x, int y)
        {
            Console.WriteLine($"Displaying texture '{Name}' at coordinates ({x}, {y}).");
        }
    }
}
