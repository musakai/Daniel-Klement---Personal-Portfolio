using Musakai.Interfaces.ApiServices;
using Musakai.Shared.Api.Contact.Requests;
using System.Net.Http.Json;

namespace Musakai.Blazor.Services.ApiServices;

/// <summary>
/// Service for sending contact messages to the Photographer
/// </summary>
public class ApiContactService : IApiContactService
{
    private readonly HttpClient _httpClient;
    private Uri _baseEndpoint = new Uri("https://api.danielklement.net/v1/contact");

    /// <summary>
    /// Constructor for the ApiContactService
    /// </summary>
    /// <param name="httpClient">HttpClient to use for sending requests</param>
    public ApiContactService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    /// <summary>
    /// Send a contact message to the Photographer
    /// </summary>
    /// <param name="request">ContactRequest containing the message details</param>
    /// <returns>Task representing the completion of the request</returns>
    public async Task SendContactMessage(ContactRequest request)
    {
        var response = await _httpClient.PostAsJsonAsync(new Uri(_baseEndpoint, "send-email"), request);
        response.EnsureSuccessStatusCode();
    }
}
