using AgriConnect.Application.Abstractions.Messaging;

namespace AgriConnect.Application.Products.ViewProducts.User;

public sealed record ViewProductsAsUserQuery() : IQuery<ViewProductsAsUserResponse>;