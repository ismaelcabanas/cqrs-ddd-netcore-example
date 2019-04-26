using System;

namespace Shared.Domain.Bus
{
    public abstract class Request : Message
    {        
        protected Request(Guid messageId) : base(messageId)
        {            
        }
        
        public Guid RequestId()
        {
            return MessageId();
        }

    }
}