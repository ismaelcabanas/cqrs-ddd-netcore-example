namespace Shared.Domain.Bus.Commands
{
    public interface ICommandBus
    {
        void Dispatch(Command command);
    }
}