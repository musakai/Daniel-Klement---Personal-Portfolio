namespace Musakai.Shared.Api.V1.Contact.Requests;

using System.ComponentModel.DataAnnotations;

/// <summary>
/// Request for sending a contact message to the Photographer
/// </summary>
public class ContactRequest
{
    /// <summary>
    /// Name of the person sending the message
    /// </summary>
    [Required(ErrorMessage = "{0} is required.")]
    [Display(Name = "First Name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Surname of the person sending the message
    /// </summary>
    [Required(ErrorMessage = "{0} is required.")]
    [Display(Name = "Last Name")]
    public string Surname { get; set; } = string.Empty;

    /// <summary>
    /// Email address of the person sending the message
    /// </summary>
    [Required(ErrorMessage = "{0} is required.")]
    [EmailAddress(ErrorMessage = "Invalid email format.")]
    [Display(Name = "Email Address")]
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Phone number of the person sending the message
    /// </summary>
    [Required(ErrorMessage = "{0} is required.")]
    [Phone(ErrorMessage = "Invalid phone number format.")]
    [Display(Name = "Phone Number")]
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    /// Message to be sent to the Photographer
    /// </summary>
    [Required(ErrorMessage = "{0} is required.")]
    [Display(Name = "Message")]
    public string Message { get; set; } = string.Empty;
}