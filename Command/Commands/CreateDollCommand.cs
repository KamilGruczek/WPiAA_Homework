using Command.Factory;
using Command.Gifts;

namespace Command.Commands
{
    internal class CreateDollCommand : ICommand
    {
        private readonly SantaClausFactory _factory;

        public CreateDollCommand(SantaClausFactory factory)
        {
            _factory = factory;
        }

        public Gift Execute()
        {
            return _factory.CreateGift("doll");
        }
    }
}
