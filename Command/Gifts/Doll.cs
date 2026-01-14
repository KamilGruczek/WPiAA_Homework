using System.Diagnostics.CodeAnalysis;

namespace Command.Gifts
{
    internal class Doll : Gift
    {
        [SetsRequiredMembers]
        public Doll()
        {
            Name = "Doll";
        }
    }
}
