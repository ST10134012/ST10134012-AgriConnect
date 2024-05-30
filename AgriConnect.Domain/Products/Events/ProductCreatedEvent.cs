using AgriConnect.Domain.Abstractions;

namespace AgriConnect.Domain.Products.Events;

public sealed record ProductCreatedEvent(Guid Id): IDomainEvent;