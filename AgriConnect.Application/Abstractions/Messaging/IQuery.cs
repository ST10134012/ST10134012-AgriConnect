using AgriConnect.Domain.Abstractions;
using MediatR;

namespace AgriConnect.Application.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}