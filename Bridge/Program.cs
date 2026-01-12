using Bridge.OperatingSystemInterfaces;
using Bridge.OperatingSystems;

Console.WriteLine("Hello in Bridge OS App.");

Console.WriteLine("Creating Windows system (always GUI):");
var windows = new WindowsSystem();
windows.DisplayMenu();
Console.WriteLine();

Console.WriteLine("Creating Linux system with Console Interface:");
var linuxConsole = new LinuxSystem(new ConsoleInterface());
linuxConsole.DisplayMenu();
Console.WriteLine();

Console.WriteLine("Creating Linux system with Graphic Interface:");
var linuxGraphic = new LinuxSystem(new GraphicInterface());
linuxGraphic.DisplayMenu();
Console.WriteLine();

Console.WriteLine("\nHave a beautiful day!");
Console.ReadKey();
