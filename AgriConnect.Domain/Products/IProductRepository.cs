namespace AgriConnect.Domain.Products;

public interface IProductRepository
{
    Task<IReadOnlyCollection<Product>> GetProductsAsync(CancellationToken cancellationToken);
    
    Task<IReadOnlyCollection<Product>> GetProductsForLoggedInFarmerAsync(Guid farmerId, CancellationToken cancellationToken);
    Task<Product> GetProductAsync(Guid id, CancellationToken cancellationToken);
    void Add(Product product);
    Task UpdateProductAsync(Product product, CancellationToken cancellationToken);
    Task DeleteProductAsync(Guid id, CancellationToken cancellationToken);
    
}