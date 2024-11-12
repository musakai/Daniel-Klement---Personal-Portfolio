namespace Musakai.Shared.Api.ErrorResponses;

/// <summary>
/// Error response for internal server errors
/// </summary>
public sealed record class InternalServerErrorResponse(string details) : BaseErrorResponse(details)
{
    /// <summary>
    /// Status code of the error
    /// </summary>
     public override int StatusCode { get; init; } = 500;

    /// <summary>
    /// Basic Message of the error
    /// </summary>
    public override string Message { get; init; } = "Internal Server Error";
}
