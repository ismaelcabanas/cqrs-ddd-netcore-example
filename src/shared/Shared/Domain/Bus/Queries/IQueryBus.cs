namespace Shared.Domain.Bus.Queries
{
    public interface IQueryBus
    {
        IResult Ask(IQuery query);
    }
}