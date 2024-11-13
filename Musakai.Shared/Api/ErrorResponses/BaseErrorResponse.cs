namespace Musakai.Shared.Api.ErrorResponses;

/// <summary>
/// Base error response for the API
/// </summary>
public record class BaseErrorResponse(string details) : IErrorResponse
{
    /// <summary>
    /// Status Code of the error
    /// </summary>
    public virtual int StatusCode { get; init; }

    /// <summary>
    /// Message of the error
    /// </summary>
    public virtual string Message { get; init; } = string.Empty;

    /// <summary>
    /// Detailed Error Message
    /// </summary>
    public string Details { get; init; } = details;
}
