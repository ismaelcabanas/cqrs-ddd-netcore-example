using Shared.Domain.Bus;
using Shared.Domain.Bus.Command;
using Shared.Tests.Fakes;
using Shared.Tests.Spys;

namespace Shared.Tests.Stubs
{
    public sealed class HandlerResolverStub : IHandlerResolver
    {
        private ICommandHandler<SomeCommand> _commandHandler;
        public HandlerResolverStub(ICommandHandler<Command> commandHandler)
        {
            _commandHandler = commandHandler;
        }

        public THandler ResolveHandler<THandler>()
        {
            return _commandHandler;
        }
    }
}