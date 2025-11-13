using System.Diagnostics.CodeAnalysis;

namespace WPiAA_Homework.DesignPatterns.Factory.Warriors
{
    public class Konny : Wojownik
    {
        [SetsRequiredMembers]
        public Konny(string name, int age)
        {
            Name = name;
            Age = age;
            Weapon = "lance";
        }
    }
}
