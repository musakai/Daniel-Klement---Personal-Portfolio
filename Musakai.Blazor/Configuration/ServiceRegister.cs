namespace Musakai.Blazor.Configuration;

using Musakai.Blazor.Services.ApiServices;
using Musakai.Interfaces.ApiServices;

/// <summary>
/// Class to register services into the Webapplication
/// </summary>
public static class ServiceRegister
{
    /// <summary>
    /// Registers the services into the Webapplication
    /// </summary>
    /// <param name="services">ServiceCollection to add services to</param>
    public static void RegisterApiServices(this IServiceCollection services)
    {
        services.AddScoped<IApiContactService, ApiContactService>();
    }
}
