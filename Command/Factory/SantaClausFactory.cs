using Command.Gifts;

namespace Command.Factory
{
    internal class SantaClausFactory
    {
        public Gift CreateGift(string toyType)
        {
            return toyType.ToLower() switch
            {
                "doll" => new Doll(),
                "car" => new Car(),
                "puzzle" => new Puzzle(),
                "rod" => new Rod(),
                _ => throw new ArgumentException("Unknown toy type")
            };
        }
    }
}