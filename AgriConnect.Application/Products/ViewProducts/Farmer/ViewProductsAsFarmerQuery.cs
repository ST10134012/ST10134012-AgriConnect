using AgriConnect.Application.Abstractions.Messaging;

namespace AgriConnect.Application.Products.ViewProducts.Farmer;

public record ViewProductsAsFarmerQuery(Guid farmerId) : IQuery<ViewProductsAsFarmerResponse>;
 