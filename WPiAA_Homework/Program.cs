// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var garnizon = new WPiAA_Homework.DesignPatterns.Builder.Garnizon();
var warriors = garnizon.CreateGarnizon();
foreach (var warrior in warriors)
{
    warrior.Fight();
}

Console.ReadLine();
