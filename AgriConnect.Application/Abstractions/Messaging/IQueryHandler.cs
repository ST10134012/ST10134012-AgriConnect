using AgriConnect.Domain.Abstractions;
using MediatR;

namespace AgriConnect.Application.Abstractions.Messaging;

public interface IQueryHandler<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
    where TQuery : IQuery<TResponse>
{
}