using Musakai.Shared.Api.V1.Contact.Requests;

namespace Musakai.Interfaces.ApiServices;

/// <summary>
/// Interface for sending contact messages to the Photographer.
/// </summary>
public interface IApiContactService
{
    /// <summary>
    /// Sends a contact message to the Photographer.
    /// </summary>
    /// <param name="request">The <see cref="ContactRequest"/> containing the message details, including name, surname, email, phone, and message content.</param>
    /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
    Task SendContactMessage(ContactRequest request);
}

