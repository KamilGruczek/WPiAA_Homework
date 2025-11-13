// Builder
var garnizon = new WPiAA_Homework.DesignPatterns.Builder.Garnizon();
var warriors = garnizon.CreateGarnizon();
foreach (var warrior in warriors)
{
    warrior.Fight();
}

Console.ReadKey();

// Prototype
var prototype = new WPiAA_Homework.DesignPatterns.Prototype.Prototype();
prototype.Run();

Console.ReadKey();
