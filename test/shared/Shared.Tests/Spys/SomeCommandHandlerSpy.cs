using Shared.Domain.Bus.Command;
using Shared.Tests.Fakes;

namespace Shared.Tests.Spys
{
    public sealed class SomeCommandHandlerSpy : ICommandHandler
    {
        private bool _commandHandled = false;                

        public bool ShouldHandle(Command command)
        {
            return _commandHandled;
        }

        public void Handle(Command command)
        {
            _commandHandled = true;
        }
    }
}