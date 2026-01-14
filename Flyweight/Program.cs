using Flyweight;

Console.WriteLine("Hello in Flyweight App.");

var textures = new Textures();
var texture1 = textures.GetTexture("grass", "textures/grass.png");
var texture2 = textures.GetTexture("water", "textures/water.png");
var texture3 = textures.GetTexture("grass", "textures/grass.png");

texture1.Render(10, 20);
texture2.Render(30, 40);
texture3.Render(50, 60);

Console.WriteLine("\nHave a beautiful day!");
Console.ReadKey();
