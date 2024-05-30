using AgriConnect.Application.Abstractions.Messaging;
using AgriConnect.Application.Products.ViewProducts.Employee;
using AgriConnect.Domain.Abstractions;
using AgriConnect.Domain.Products;

namespace AgriConnect.Application.Products.ViewProducts.Farmer;

public sealed class ViewProductsAsFarmerQueryHandler(IProductRepository productRepository)
    : IQueryHandler<ViewProductsAsFarmerQuery, ViewProductsAsFarmerResponse>
{
    public async Task<Result<ViewProductsAsFarmerResponse>> Handle(ViewProductsAsFarmerQuery request, CancellationToken cancellationToken)
    {
        var products = await productRepository.GetProductsForLoggedInFarmerAsync(request.farmerId, cancellationToken);
 
        return new ViewProductsAsFarmerResponse()
        {
            Products = products.ToList()
        };
    }
}