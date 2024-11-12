namespace Musakai.Blazor.Services.ApiServices;

using Musakai.Interfaces.Blazor.ApiServices;
using Musakai.Shared.Api.V1.Contact.Requests;
using System.Net.Http.Json;

/// <summary>
/// Service for sending contact messages to the Photographer
/// </summary>
public sealed class ApiContactService : BaseApiService, IApiContactService
{
    private readonly Uri _endpointV1;

    /// <summary>
    /// Constructor for the ApiContactService
    /// </summary>
    /// <param name="httpClient">HttpClient to use for sending requests</param>
    /// <param name="configuration">Configuration to use for the base endpoint</param>
    public ApiContactService(HttpClient httpClient, IConfiguration configuration)
        : base(httpClient, configuration)
    {
        _endpointV1 = new Uri(_baseEndpoint, "v1/contact");
    }

    /// <summary>
    /// Send a contact message to the Photographer
    /// </summary>
    /// <param name="request">ContactRequest containing the message details</param>
    /// <returns>Task representing the completion of the request</returns>
    public async Task SendContactMessage(ContactRequest request)
    {
        var response = await _httpClient.PostAsJsonAsync(new Uri(_endpointV1, "send-email"), request);
        response.EnsureSuccessStatusCode();
    }
}
