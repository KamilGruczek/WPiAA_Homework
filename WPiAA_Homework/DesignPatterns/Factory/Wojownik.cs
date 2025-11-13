namespace WPiAA_Homework.DesignPatterns.Factory
{
    public class Wojownik
    {
        public required string Name { get; set; }
        public required int Age { get; set; }
        public required string Weapon { get; set; }

        public void Fight()
        {
            Console.WriteLine($"{Name} strikes with the {Weapon}!");
        }
    }
}
