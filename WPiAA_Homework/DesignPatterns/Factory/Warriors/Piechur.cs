using System.Diagnostics.CodeAnalysis;

namespace WPiAA_Homework.DesignPatterns.Factory.Warriors
{
    public class Piechur : Wojownik
    {
        [SetsRequiredMembers]
        public Piechur(string name, int age)
        {
            Name = name;
            Age = age;
            Weapon = "sword";
        }
    }
}
