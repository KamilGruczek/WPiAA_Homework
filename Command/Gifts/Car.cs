using System.Diagnostics.CodeAnalysis;

namespace Command.Gifts
{
    internal class Car : Gift
    {
        [SetsRequiredMembers]
        public Car()
        {
            Name = "Car";
        }
    }
}
