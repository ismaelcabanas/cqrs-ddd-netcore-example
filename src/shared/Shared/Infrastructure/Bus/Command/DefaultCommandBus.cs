using System;
using System.Collections.Generic;
using Shared.Domain.Bus.Commands;

namespace Shared.Infrastructure.Bus.Command
{
    public sealed class DefaultCommandBus : ICommandBus
    {
        private Dictionary<Type, ICommandHandler> _commandHandlersMapping = 
            new Dictionary<Type, ICommandHandler>();
        
        public void Dispatch(Domain.Bus.Commands.Command command)
        {
            ICommandHandler commandHandler = _commandHandlersMapping[command.GetType()];
            commandHandler.Handle(command);
        }

        public void Register(Type type, ICommandHandler commandHandler)
        {
            _commandHandlersMapping.Add(type, commandHandler);
        }
    }
}