namespace Musakai.Shared.Api.ErrorResponses.E400;

/// <summary>
/// Error response for bad requests
/// </summary>
public record class BadRequestErrorResponse : BaseErrorResponse
{
    /// <summary>
    /// Status code of the error
    /// </summary>
    public int StatusCode { get; set; } = 400;

    /// <summary>
    /// Basic Message of the error
    /// </summary>
    public string Message { get; set; } = "Bad Request";
}
