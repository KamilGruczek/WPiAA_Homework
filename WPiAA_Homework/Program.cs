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

// Factory
var factoryGarnizon = new WPiAA_Homework.DesignPatterns.Factory.Garnizon();
var factoryWarriors = new List<WPiAA_Homework.DesignPatterns.Factory.Wojownik>();

for (int i = 1; i <= 3; i++)
{
    factoryWarriors.Add(factoryGarnizon.Train("piechur", $"Piechur_{i}", 20 + i));
}

for (int i = 1; i <= 3; i++)
{
    factoryWarriors.Add(factoryGarnizon.Train("konny", $"Konny_{i}", 22 + i));
}

for (int i = 1; i <= 4; i++)
{
    factoryWarriors.Add(factoryGarnizon.Train("strzelec", $"Strzelec_{i}", 22 + i));
}

foreach (var warrior in factoryWarriors)
{
    warrior.Fight();
}

Console.ReadKey();