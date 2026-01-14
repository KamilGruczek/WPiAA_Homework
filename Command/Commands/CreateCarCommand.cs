using Command.Factory;
using Command.Gifts;

namespace Command.Commands
{
    internal class CreateCarCommand : ICommand
    {
        private readonly SantaClausFactory _factory;

        public CreateCarCommand(SantaClausFactory factory)
        {
            _factory = factory;
        }

        public Gift Execute()
        {
            return _factory.CreateGift("car");
        }
    }
}
