using WPiAA_Homework.DesignPatterns.Builder.Interfaces;

namespace WPiAA_Homework.DesignPatterns.Builder.Warriors
{
    public class Konny : IWarrior
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Weapon { get; set; } = string.Empty;

        public Konny(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Fight()
        {
            Console.WriteLine($"{Name} charges with the {Weapon}!");
        }
    }
}
