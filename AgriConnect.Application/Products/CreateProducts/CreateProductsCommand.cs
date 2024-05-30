using MediatR;

namespace AgriConnect.Application.Products.CreateProducts;

public record CreateProductsCommand(string name, string category, DateTime productionDate, string imageData, string farmerId)
    : IRequest<CreateProductsResponse>;
 