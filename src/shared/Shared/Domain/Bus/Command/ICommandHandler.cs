namespace Shared.Domain.Bus.Command
{
    public interface ICommandHandler
    {
        void Handle(Command command);
    }
}