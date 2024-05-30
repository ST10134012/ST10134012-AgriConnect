using AgriConnect.Infrastructure.Authentication.models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AgriConnect.Infrastructure;

public class AuthenticationDbContext(DbContextOptions<AuthenticationDbContext> options)
    : IdentityDbContext<ApplicationIdentityUser>(options); 