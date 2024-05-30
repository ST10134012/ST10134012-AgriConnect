using Microsoft.AspNetCore.Identity;

namespace AgriConnect.Infrastructure.Authentication.models;

public class ApplicationIdentityUser: IdentityUser
{
    public string FirstName { get; set; }  
    public string LastName { get; set; }
    
    public string GivenName { get; set; }
    
    public string FullName { get; set; }
}  