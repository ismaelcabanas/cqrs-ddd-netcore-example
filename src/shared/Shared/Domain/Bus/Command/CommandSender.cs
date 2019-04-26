using System;

namespace Shared.Domain.Bus.Command
{
    public sealed class CommandSender : ICommandSender
    {
        private readonly IHandlerResolver _handlerResolver;

        public CommandSender(IHandlerResolver handlerResolver)
        {
            _handlerResolver = handlerResolver;
        }

        public void Send<TCommand>(TCommand command) where TCommand : Command
        {
            if (command == null)
            {
                throw new ArgumentNullException(nameof(command));
            }
        }
    }
}