using Command.Factory;
using Command.Gifts;

namespace Command.Commands
{
    internal class CreatePuzzleCommand : ICommand
    {
        private readonly SantaClausFactory _factory;

        public CreatePuzzleCommand(SantaClausFactory factory)
        {
            _factory = factory;
        }

        public Gift Execute()
        {
            return _factory.CreateGift("puzzle");
        }
    }
}
