using AgriConnect.Application.Abstractions.Clock;

namespace AgriConnect.Infrastructure.Clock;

public sealed class DateTimeProvider : IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}