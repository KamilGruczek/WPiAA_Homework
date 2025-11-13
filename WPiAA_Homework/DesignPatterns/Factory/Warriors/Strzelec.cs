using System.Diagnostics.CodeAnalysis;

namespace WPiAA_Homework.DesignPatterns.Factory.Warriors
{
    public class Strzelec : Wojownik
    {
        [SetsRequiredMembers]
        public Strzelec(string name, int age)
        {
            Name = name;
            Age = age;
            Weapon = "bow";
        }
    }
}
