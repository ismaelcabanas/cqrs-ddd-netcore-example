using System;

namespace Shared.Domain.Bus
{
    public abstract class Message
    {
        private readonly Guid _messageId;

        protected Message(Guid messageId)
        {
            _messageId = messageId;
        }

        public Guid MessageId()
        {
            return _messageId;
        }

        public abstract string MessageType();
    }
}