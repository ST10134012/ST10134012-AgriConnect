using AgriConnect.Domain.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace AgriConnect.Domain;

public static class DependencyInjection
{
    public static IServiceCollection AddDomain(this IServiceCollection services)
    {
        return services;
    }
}