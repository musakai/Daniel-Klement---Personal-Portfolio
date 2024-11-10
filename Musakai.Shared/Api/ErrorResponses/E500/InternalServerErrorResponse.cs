namespace Musakai.Shared.Api.ErrorResponses.E500;

/// <summary>
/// Error response for internal server errors
/// </summary>
public class InternalServerErrorResponse : BaseErrorResponse
{
    /// <summary>
    /// Status code of the error
    /// </summary>
    public int StatusCode { get; set; } = 500;

    /// <summary>
    /// Basic Message of the error
    /// </summary>
    public string Message { get; set; } = "Internal Server Error";
}
