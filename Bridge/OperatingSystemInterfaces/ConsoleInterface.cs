namespace Bridge.OperatingSystemInterfaces
{
    internal class ConsoleInterface : Interface
    {
        internal override void DisplayMenu(List<string> programs)
        {
            Console.WriteLine("--- Console Interface - Menu ---");
            Console.WriteLine("Installed Programs:");

            for (int i = 0; i < programs.Count; i++)
            {
                Console.WriteLine($"  {i + 1}. {programs[i]}");
            }

            Console.WriteLine("--------------------------------");
        }
    }
}
