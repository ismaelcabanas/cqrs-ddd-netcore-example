namespace Shared.Domain.Bus.Queries
{
    public interface IQueryHandler
    {
        IResult Retrieve(IQuery query);
    }
}