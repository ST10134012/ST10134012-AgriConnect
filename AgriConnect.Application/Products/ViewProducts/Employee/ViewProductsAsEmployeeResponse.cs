using AgriConnect.Domain.Products;

namespace AgriConnect.Application.Products.ViewProducts.Employee;

public sealed class ViewProductsAsEmployeeResponse
{
   public  IReadOnlyList<ProductsEmployeeModel> Products { get; set; } = new List<ProductsEmployeeModel>();
}