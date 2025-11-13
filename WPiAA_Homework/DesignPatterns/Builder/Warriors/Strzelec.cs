using WPiAA_Homework.DesignPatterns.Builder.Interfaces;

namespace WPiAA_Homework.DesignPatterns.Builder.Warriors
{
    public class Strzelec : IWarrior
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Weapon { get; set; } = string.Empty;

        public Strzelec(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Fight()
        {
            Console.WriteLine($"{Name} shoots an arrow from the {Weapon}!");
        }
    }
}
