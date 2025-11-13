using WPiAA_Homework.DesignPatterns.Builder.Interfaces;

namespace WPiAA_Homework.DesignPatterns.Builder.Warriors
{
    public class Piechur : IWarrior
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Weapon
        {
            get
            {
                return "sword";
            }
        }

        public Piechur(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Fight()
        {
            Console.WriteLine($"{Name} strikes with the {Weapon}!");
        }
    }
}
