using Microsoft.Build.Framework;

namespace AgriConnect.WebApp.Components.Pages.Farmer.FarmerProducts.AddProduct;

public class AddProductRequest
{
    [Required]
    public string Name { get; set; }

    [Required]
    public string Category { get; set; } 

    [Required]
    public DateTime ProductionDate { get; set; } = DateTime.Now;
    
    [Required]
    public byte[] ImageData { get; set; }
}