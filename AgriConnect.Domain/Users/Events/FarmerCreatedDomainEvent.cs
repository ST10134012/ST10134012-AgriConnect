using AgriConnect.Domain.Abstractions;

namespace AgriConnect.Domain.Users.Events;

public sealed record FarmerCreatedDomainEvent(Guid Id) : IDomainEvent;