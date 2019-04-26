using Shared.Domain.Bus;
using Shared.Domain.Bus.Command;

namespace Shared.Tests.Stubs
{
    public sealed class HandlerResolverStub : IHandlerResolver
    {
        private readonly ICommandHandler _commandHandler;
        public HandlerResolverStub(ICommandHandler commandHandler)
        {
            _commandHandler = commandHandler;
        }
        
        public ICommandHandler ResolveHandler(Command command)
        {
            return _commandHandler;
        }
    }
}