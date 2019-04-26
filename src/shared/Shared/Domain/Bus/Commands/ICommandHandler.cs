namespace Shared.Domain.Bus.Commands
{
    public interface ICommandHandler
    {
        void Handle(Command command);
    }
}