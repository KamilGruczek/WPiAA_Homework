namespace Flyweight
{
    internal class Textures
    {
        private readonly Dictionary<string, Texture> _textures = new();

        public Texture GetTexture(string name, string path)
        {
            if (!_textures.TryGetValue(name, out var texture))
            {
                texture = new Texture(name, path);
                _textures[name] = texture;
            }
            return texture;
        }
    }
}
