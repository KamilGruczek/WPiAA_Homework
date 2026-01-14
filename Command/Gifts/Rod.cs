using System.Diagnostics.CodeAnalysis;

namespace Command.Gifts
{
    internal class Rod : Gift
    {
        [SetsRequiredMembers]
        public Rod()
        {
            Name = "Rod";
        }
    }
}
