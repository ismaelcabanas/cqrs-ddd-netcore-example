using System.Collections.Generic;

namespace Shared.Domain.Bus
{
    public interface IResolver
    {
        T Resolve<T>();
        IEnumerable<T> ResolveAll<T>();
    }
}