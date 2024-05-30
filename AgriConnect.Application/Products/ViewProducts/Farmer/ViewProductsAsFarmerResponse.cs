using AgriConnect.Domain.Products;

namespace AgriConnect.Application.Products.ViewProducts.Farmer;

public sealed class ViewProductsAsFarmerResponse
{
    public  IReadOnlyList<Product> Products { get; set; } = new List<Product>();
}