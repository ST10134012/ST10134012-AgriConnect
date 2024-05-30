using AgriConnect.Domain.Abstractions;

namespace AgriConnect.Domain.Users.Events;

public sealed record EmployeeCreatedDomainEvent(Guid Id): IDomainEvent;