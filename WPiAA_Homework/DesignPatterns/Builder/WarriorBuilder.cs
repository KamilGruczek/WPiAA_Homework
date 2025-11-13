using WPiAA_Homework.DesignPatterns.Builder.Interfaces;

namespace WPiAA_Homework.DesignPatterns.Builder
{
    internal abstract class WarriorBuilder
    {
        internal abstract void BuildWarrior(string name, int age);
        internal abstract void BuildWeapon();
        internal abstract void Train();

        internal IWarrior Warrior { get; set; }
    }
}
