using Command.Gifts;

namespace Command.Commands
{
    internal interface ICommand
    {
        Gift Execute();
    }
}
