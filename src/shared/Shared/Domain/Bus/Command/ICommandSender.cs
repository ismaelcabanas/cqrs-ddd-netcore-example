namespace Shared.Domain.Bus.Command
{
    public interface ICommandSender
    {
        void Send<TCommand>(TCommand command) where TCommand : Command;
    }
}