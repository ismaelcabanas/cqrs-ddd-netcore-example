using FluentAssertions;
using Shared.Domain.Bus.Commands;

namespace Shared.Tests.Mocks
{
    public sealed class CommandHandlerMock : ICommandHandler
    {
        private int invocationTimes = 0;
        
        public void Handle(Command command)
        {
            invocationTimes++;
        }

        public void ShouldBeCalledOnce()
        {
            invocationTimes.Should().Be(1);
        }
    }
}