namespace Shared.Domain.Bus
{
    public interface IHandlerResolver
    {
        THandler ResolveHandler<THandler>();
    }
}