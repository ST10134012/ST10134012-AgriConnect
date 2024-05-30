using AgriConnect.Application.Abstractions.Messaging;
using AgriConnect.Domain.Abstractions;
using AgriConnect.Domain.Products;

namespace AgriConnect.Application.Products.ViewProducts.Employee;

public sealed class ViewProductsAsEmployeeQueryHandler(IProductRepository productRepository)
    : IQueryHandler<ViewProductsAsEmployeeQuery, ViewProductsAsEmployeeResponse>
{
 

    public async Task<Result<ViewProductsAsEmployeeResponse>> Handle(ViewProductsAsEmployeeQuery request, CancellationToken cancellationToken)
    {
        var products = await productRepository.GetProductsAsync(cancellationToken);
 
        var response = new ViewProductsAsEmployeeResponse()
        {
            Products = products.ToList().Select(products=> new ProductsEmployeeModel
            {
                FullName = products.Farmer.FirstName.Value + " " + products.Farmer.LastName.Value,
                ProductName = products.Name.Value,
                ProductCategory = products.Category.Value,
                ProductionDate = products.ProductionDateUtc
            }).ToList()
        };

        return response;
    }
}
 