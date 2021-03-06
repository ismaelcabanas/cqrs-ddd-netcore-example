using System;

namespace Shared.Domain.Bus.Commands
{
    public abstract class Command : Request
    {
        public Command(Guid messageId) : base(messageId)
        {
        }

        public Guid CommandId()
        {
            return RequestId();
        }
        
        public override string MessageType()
        {
            return "command";
        }
    }
}