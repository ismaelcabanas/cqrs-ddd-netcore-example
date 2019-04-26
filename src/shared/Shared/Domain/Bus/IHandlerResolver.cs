using Shared.Domain.Bus.Commands;

namespace Shared.Domain.Bus
{
    public interface IHandlerResolver
    {
        ICommandHandler ResolveHandler(Command command);
    }
}