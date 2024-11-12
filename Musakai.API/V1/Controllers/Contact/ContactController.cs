namespace Musakai.API.V1.Controllers.Contact;

using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using Musakai.Shared.Api.V1.Contact.Requests;
using Musakai.Shared.Api.ErrorResponses.E400;
using Musakai.Shared.Api.ErrorResponses.E500;

/// <summary>
/// Controller for handling contact messages.
/// </summary>
[ApiController]
[ApiVersion(1.0)]
[Produces("application/json")]
[Route("/v{version:apiVersion}/[controller]")]
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
    [Consumes("application/json")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(BadRequestErrorResponse), StatusCodes.Status400BadRequest)]
    [ProducesResponseType(typeof(InternalServerErrorResponse), StatusCodes.Status500InternalServerError)]
    public async Task<IActionResult> SendContactMessage([FromBody] ContactRequest request)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(new BadRequestErrorResponse
            {
                Details = ModelState.ToString()!
            });
        }

        try
        {
            // TODO (#21): Implement the IEmailService and use it to send the contact message
            // This issue is tracked on GitHub: https://github.com/musakai/Daniel-Klement---Personal-Portfolio/issues/21
            return Ok("");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "");
            return StatusCode(500, new InternalServerErrorResponse
            {
                Details = ex.Message
            });
        }
    }
}