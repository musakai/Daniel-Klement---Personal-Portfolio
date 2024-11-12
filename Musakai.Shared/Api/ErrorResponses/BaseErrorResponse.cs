namespace Musakai.Shared.Api.ErrorResponses;

/// <summary>
/// Base error response for the API
/// </summary>
public record class BaseErrorResponse
{
    /// <summary>
    /// Detailed Error Message
    /// </summary>
    public string Details { get; set; } = string.Empty;
}
