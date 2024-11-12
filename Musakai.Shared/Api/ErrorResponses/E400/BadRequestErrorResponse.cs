namespace Musakai.Shared.Api.ErrorResponses;

/// <summary>
/// Error response for bad requests
/// </summary>
public sealed record class BadRequestErrorResponse(string details) : BaseErrorResponse(details)
{
    /// <summary>
    /// Status code of the error
    /// </summary>
    public override int StatusCode { get; init; } = 400;

    /// <summary>
    /// Basic Message of the error
    /// </summary>
    public override string Message { get; init; } = "Bad Request";
}
