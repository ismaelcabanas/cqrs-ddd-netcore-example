using Shared.Domain.Bus.Command;
using Shared.Tests.Fakes;

namespace Shared.Tests.Spys
{
    public sealed class SomeCommandHandlerSpy : ICommandHandler<SomeCommand>
    {
        private bool _commandHandled = false;
        
        public void Handle(SomeCommand command)
        {
            _commandHandled = true;
        }

        public bool ShouldHandle(Command command)
        {
            return _commandHandled;
        }
    }
}