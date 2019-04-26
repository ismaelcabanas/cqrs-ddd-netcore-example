using System;
using FluentAssertions;
using Shared.Domain.Bus;
using Shared.Domain.Bus.Commands;
using Shared.Tests.Fakes;
using Shared.Tests.Spys;
using Shared.Tests.Stubs;
using Xunit;

namespace Shared.Tests.Domain.Bus.Command
{
    public sealed class CommandSenderShould
    {

        private readonly ICommandSender _sut;
        private SomeCommand _someCommand;
        private readonly SomeCommandHandlerSpy _commandHandlerSpy;
        private IHandlerResolver _handlerResolver;

        public CommandSenderShould()
        {
            _commandHandlerSpy = new SomeCommandHandlerSpy();
            _handlerResolver = new HandlerResolverStub(_commandHandlerSpy);
            _sut = new CommandSender(_handlerResolver);
        }

        [Fact]
        public void Throw_Exception_When_Command_Is_Null()
        {
            // given            
            _someCommand = null;
            
            // when
            Action action = () => _sut.Send(_someCommand);
            
            // then
            action.Should().ThrowExactly<ArgumentNullException>();
        }

        [Fact]
        public void Sends_Command()
        {
            // given
            _someCommand = new SomeCommand(Guid.NewGuid());
            
            // when
            _sut.Send(_someCommand);
            
            // then
            _commandHandlerSpy.ShouldHandle(_someCommand).Should().BeTrue();
        }
    }
}