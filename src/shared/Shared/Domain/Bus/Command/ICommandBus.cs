namespace Shared.Domain.Bus.Command
{
    public interface ICommandBus
    {
        void Dispatch(Command command);
    }
}