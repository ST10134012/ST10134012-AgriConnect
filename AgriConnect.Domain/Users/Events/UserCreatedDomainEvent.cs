using AgriConnect.Domain.Abstractions;

namespace AgriConnect.Domain.Users.Events;

public sealed record UserCreatedDomainEvent(Guid userId) : IDomainEvent;