namespace Musakai.Shared.Api.ErrorResponses;

/// <summary>
/// Interface for error response
/// </summary>
public interface IErrorResponse
{
    /// <summary>
    /// Status Code of the Error
    /// </summary>
    public int StatusCode { get; }

    /// <summary>
    /// Message of the Error
    /// </summary>
    public string Message { get; }

    /// <summary>
    /// Details of the Error
    /// </summary>
    public string Details { get; }
}
