using System.Diagnostics.CodeAnalysis;

namespace Command.Gifts
{
    internal class Puzzle : Gift
    {
        [SetsRequiredMembers]
        public Puzzle()
        {
            Name = "Puzzle";
        }
    }
}
