using Command.Factory;
using Command.Gifts;

namespace Command.Commands
{
    internal class CreateRodCommand : ICommand
    {
        private readonly SantaClausFactory _factory;

        public CreateRodCommand(SantaClausFactory factory)
        {
            _factory = factory;
        }

        public Gift Execute()
        {
            return _factory.CreateGift("rod");
        }
    }
}
