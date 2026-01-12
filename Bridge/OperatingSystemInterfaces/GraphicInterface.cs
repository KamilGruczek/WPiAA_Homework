namespace Bridge.OperatingSystemInterfaces
{
    internal class GraphicInterface : Interface
    {
        internal override void DisplayMenu(List<string> programs)
        {
            Console.WriteLine("=== Graphic Interface - Menu ===");
            Console.WriteLine("Installed Programs:");

            foreach (var program in programs)
            {
                Console.WriteLine($"  [Icon] {program}");
            }

            Console.WriteLine("================================");
        }
    }
}
