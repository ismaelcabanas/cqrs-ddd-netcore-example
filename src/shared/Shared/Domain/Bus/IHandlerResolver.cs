using Shared.Domain.Bus.Command;

namespace Shared.Domain.Bus
{
    public interface IHandlerResolver
    {
        ICommandHandler ResolveHandler(Command.Command command);
    }
}