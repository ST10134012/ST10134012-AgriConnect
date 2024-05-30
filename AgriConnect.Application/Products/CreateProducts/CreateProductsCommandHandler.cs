using AgriConnect.Domain.Abstractions;
using AgriConnect.Domain.Products;
using AgriConnect.Domain.Users;
using MediatR;

namespace AgriConnect.Application.Products.CreateProducts;

public sealed class CreateProductsCommandHandler(IProductRepository productRepository, IUnitOfWork unitOfWork)
    : IRequestHandler<CreateProductsCommand, CreateProductsResponse>
{
    public async Task<CreateProductsResponse> Handle(CreateProductsCommand request, CancellationToken cancellationToken)
    {
         var newProduct = Product.CreateProduct(
             new ProductName(request.name),
             new Category(request.category),
             request.productionDate,
             new Photo( request.imageData), 
             Guid.Parse(request.farmerId));
         
            productRepository.Add(newProduct);
            
            await unitOfWork.SaveChangesAsync(cancellationToken);
            
            return new CreateProductsResponse() { Id = newProduct.Id.ToString() };
    }
} 
  