using System.Collections.Generic;

namespace Shared.Domain
{
    public abstract class AggregateRoot
    {
        private List<DomainEvent> _recordedDomainEvents = new List<DomainEvent>();

        public List<DomainEvent> PullDomainEvents() {
            var recordedDomainEvents = _recordedDomainEvents;
            _recordedDomainEvents = new List<DomainEvent>();

            return recordedDomainEvents;
        }

        protected void Record(DomainEvent evt) {
            _recordedDomainEvents.Add(evt);
        }
    }
}