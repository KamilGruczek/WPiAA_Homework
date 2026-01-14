using Command.Commands;
using Command.Gifts;

namespace Command.Factory
{
    internal class Elf
    {
        private readonly List<ICommand> _commands = [];
        private readonly List<Gift> _gifts = [];

        internal void TakeOrder(ICommand command)
        {
            _commands.Add(command);
        }

        internal void PrepareGifts()
        {
            foreach (var command in _commands)
            {
                var gift = command.Execute();
                _gifts.Add(gift);
            }
            _commands.Clear();
        }

        internal List<Gift> GetPreparedGifts()
        {
            return _gifts;
        }
    }
}
