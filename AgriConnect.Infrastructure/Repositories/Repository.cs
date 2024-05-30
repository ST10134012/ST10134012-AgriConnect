using AgriConnect.Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace AgriConnect.Infrastructure.Repositories;

internal abstract class Repository<T>(ApplicationDbContext dbContext) where T : Entity
{
    protected readonly ApplicationDbContext DbContext = dbContext;

    public async Task<T?> GetByIdAsync(
        Guid id,
        CancellationToken cancellationToken = default)
    {
        return await DbContext
            .Set<T>()
            .FirstOrDefaultAsync(predicate => predicate.Id == id, cancellationToken);
    }
 
    public virtual void Add(T entity) 
    { 
        DbContext.Add(entity);
    }
}