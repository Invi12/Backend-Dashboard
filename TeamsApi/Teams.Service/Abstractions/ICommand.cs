using MediatR;

namespace Teams.Service.Abstractions;

public interface ICommand<TResult> : IRequest<TResult>
{
}

public interface ICommand : ICommand<Unit>
{
}