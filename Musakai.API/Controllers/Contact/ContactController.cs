using Microsoft.AspNetCore.Mvc;
using Musakai.Shared.Api.Contact.Requests;

namespace Musakai.API.Controllers.Contact;

[ApiController]
[Route("v1/[controller]")]
public class ContactController : ControllerBase
{
    private readonly ILogger<ContactController> _logger;
    /// <summary>
    /// Constructor for the ContactController.
    /// </summary>
    public ContactController(ILogger<ContactController> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    /// <summary>
    /// Endpoint to send a contact message to the photographer.
    /// </summary>
    /// <param name="request">The contact request containing the message details.</param>
    /// <returns>Action result indicating the outcome of the operation.</returns>
    [HttpPost("send-email")]
    public async Task<IActionResult> SendContactMessage([FromBody] ContactRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        try
        {
            // Send the contact message here
            return Ok("");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "");
            return StatusCode(500, "");
        }
    }
}