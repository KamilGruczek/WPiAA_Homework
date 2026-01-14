using Command.Commands;
using Command.Factory;

Console.WriteLine("Hello in Santa Claus Commands App.");
var factory = new SantaClausFactory();
var elf = new Elf();

var dollCommand = new CreateDollCommand(factory);
var carCommand = new CreateCarCommand(factory);
var puzzleCommand = new CreatePuzzleCommand(factory);
var rodCommand = new CreateRodCommand(factory);


Console.WriteLine("Taking orders...");
elf.TakeOrder(dollCommand);
elf.TakeOrder(carCommand);
elf.TakeOrder(puzzleCommand);
elf.TakeOrder(rodCommand);

Console.WriteLine("Elf is hardworking on preparing gifts...");
elf.PrepareGifts();

Console.WriteLine("Preparing completed");
var gifts = elf.GetPreparedGifts();
foreach (var gift in gifts)
{
    Console.WriteLine($"- {gift.Name}");
}

Console.WriteLine("\nHave a beautiful day!");
Console.ReadKey();
