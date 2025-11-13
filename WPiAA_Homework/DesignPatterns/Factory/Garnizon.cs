using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPiAA_Homework.DesignPatterns.Factory
{
    internal class Garnizon
    {
        public Wojownik Train(string profession, string name, int age)
        {
            return profession.Trim().ToLowerInvariant() switch
            {
                "piechur" => new Warriors.Piechur(name, age),
                "strzelec" => new Warriors.Strzelec(name, age),
                "konny" => new Warriors.Konny(name, age),
                _ => throw new ArgumentException($"Unknown profession: {profession}")
            };
        }
    }
}
