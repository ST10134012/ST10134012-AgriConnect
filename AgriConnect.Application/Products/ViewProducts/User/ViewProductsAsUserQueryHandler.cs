using AgriConnect.Application.Abstractions.Messaging;
using AgriConnect.Domain.Abstractions;
using AgriConnect.Domain.Products;

namespace AgriConnect.Application.Products.ViewProducts.User;

public sealed class ViewProductsAsUserQueryHandler(IProductRepository productRepository)
    : IQueryHandler<ViewProductsAsUserQuery, ViewProductsAsUserResponse>
{
    private readonly IProductRepository _productRepository = productRepository;

    public async Task<Result<ViewProductsAsUserResponse>> Handle(ViewProductsAsUserQuery request, CancellationToken cancellationToken)
    {
        var results = await _productRepository.GetProductsAsync(cancellationToken);
        
        return Result.Success(new ViewProductsAsUserResponse
        {
            Products = results.ToList()
        });
        
    }
}
 