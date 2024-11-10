namespace Musakai.Blazor.Services.ApiServices;

/// <summary>
/// Base class for ApiServices
/// </summary>
public class BaseApiService
{
    /// <summary>
    /// HttpClient to use for sending requests
    /// </summary>
    protected readonly HttpClient _httpClient;

    /// <summary>
    /// Base endpoint for the API
    /// </summary>
    protected readonly Uri _baseEndpoint;

    /// <summary>
    /// Constructor for the BaseApiService
    /// </summary>
    /// <param name="httpClient"></param>
    /// <param name="configuration"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public BaseApiService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException();
        _baseEndpoint = new Uri(configuration["apiBaseUri"] ?? throw new ArgumentNullException(nameof(configuration)));
    }
}
