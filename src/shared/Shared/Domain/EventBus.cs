using System.Collections.Generic;

namespace Shared.Domain
{
    public interface EventBus
    {
        void Publish(List<DomainEvent> events);
    }
}