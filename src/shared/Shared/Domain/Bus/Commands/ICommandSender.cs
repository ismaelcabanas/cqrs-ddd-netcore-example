namespace Shared.Domain.Bus.Commands
{
    public interface ICommandSender
    {
        void Send<TCommand>(TCommand command) where TCommand : Command;
    }
}