using WPiAA_Homework.DesignPatterns.Builder.Warriors;

namespace WPiAA_Homework.DesignPatterns.Builder
{
    internal class StrzelecBuilder : WarriorBuilder
    {
        internal override void BuildWarrior(string name, int age)
        {
            Warrior = new Strzelec(name, age);
        }

        internal override void BuildWeapon()
        {
            Warrior.Weapon = "bow";
            Console.WriteLine($"{Warrior.Name} is equipped with a {Warrior.Weapon}.");
        }

        internal override void Train()
        {
            Console.WriteLine($"{Warrior.Name} is training in archery.");
        }
    }
}
