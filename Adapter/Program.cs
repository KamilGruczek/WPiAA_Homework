using Adapter;

var christopherAge = 17;
Console.WriteLine($"Christopher is {christopherAge} years old.");
var nightClub = new NightClub(new Adult());
if (nightClub.CanEnter(christopherAge))
{
    Console.WriteLine("Christopher can enter the night club.");
}
else
{
    Console.WriteLine("Christopher cannot enter the night club.");
}

nightClub = new NightClub(new FakeAdult());
if (nightClub.CanEnter(christopherAge))
{
    Console.WriteLine("Christopher can enter the night club (using FakeAdult).");
}
else
{
    Console.WriteLine("Christopher cannot enter the night club (using FakeAdult).");
}

Console.WriteLine("Program finished.");
Console.ReadKey();
