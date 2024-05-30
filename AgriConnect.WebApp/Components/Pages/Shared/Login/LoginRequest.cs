namespace AgriConnect.WebApp.Components.Pages.Shared.Login;

public sealed class LoginRequest
{
    public string Username { get; set; }
    public string Password { get; set; }

    public bool RememberMe { get; set; }
}