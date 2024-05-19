using MediatR;

namespace BuildingBlocks.CQRS;

// Used to define a query that has to return a response
public interface IQuery<out TResponse> : IRequest<TResponse>
    where TResponse : notnull
{

}

