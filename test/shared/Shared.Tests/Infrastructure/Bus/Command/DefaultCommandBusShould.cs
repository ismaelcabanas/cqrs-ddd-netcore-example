using Shared.Infrastructure.Bus.Command;
using Shared.Tests.Mocks;
using Shared.Tests.Spies;
using Xunit;

namespace Shared.Tests.Infrastructure.Bus.Command
{
    public sealed class DefaultCommandBusShould
    {
        private DefaultCommandBus _sut;
        
        [Fact]
        public void Be_Able_To_Handle_A_Command()
        {
           // given
           var someSpyCommand = new SomeSpyCommand();
           CommandHandlerMock commandHandlerMock = new CommandHandlerMock();
           _sut = new DefaultCommandBus();
           _sut.Register(someSpyCommand.GetType(), commandHandlerMock);
           
           // when
           _sut.Dispatch(someSpyCommand);
           
           // then           
           someSpyCommand.ShouldBeCommandTypeMessage();
           commandHandlerMock.ShouldBeCalledOnce();
        }
                
    }
}