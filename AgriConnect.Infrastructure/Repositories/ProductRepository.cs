using AgriConnect.Domain.Products;
using Microsoft.EntityFrameworkCore;

namespace AgriConnect.Infrastructure.Repositories;

internal sealed class ProductRepository(ApplicationDbContext dbContext) : Repository<Product>(dbContext), IProductRepository
{
    public async Task<IReadOnlyCollection<Product>> GetProductsAsync(CancellationToken cancellationToken)
    {
        return await dbContext.Set<Product>().Include(product=> product.Farmer).ToListAsync(cancellationToken: cancellationToken);
    }

    public async Task<IReadOnlyCollection<Product>> GetProductsForLoggedInFarmerAsync(Guid farmerId, CancellationToken cancellationToken)
    {
        return await dbContext.Set<Product>().Where(product => product.FarmerId == farmerId).ToListAsync(cancellationToken: cancellationToken);
    }

    public Task<Product> GetProductAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public override void Add(Product product)
    {
        dbContext.Add(product);
    }

    public Task UpdateProductAsync(Product product, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task DeleteProductAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}