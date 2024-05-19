using MediatR;


namespace BuildingBlocks.CQRS;

// Used to define a command that does not return a response
public interface ICommand : ICommand<Unit>
{
}

//Used to define a command that returns a response
public interface ICommand<out TResponse> :IRequest<TResponse>
{
}

