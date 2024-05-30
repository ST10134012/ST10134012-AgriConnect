using AgriConnect.Domain.Products;

namespace AgriConnect.Application.Products.ViewProducts.User;

public sealed class ViewProductsAsUserResponse
{
    public  IReadOnlyList<Product> Products { get; set; } = new List<Product>();
}