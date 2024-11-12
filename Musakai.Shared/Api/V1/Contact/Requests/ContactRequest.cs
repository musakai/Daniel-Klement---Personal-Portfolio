namespace Musakai.Shared.Api.V1.Contact.Requests;

using System.ComponentModel.DataAnnotations;

/// <summary>
/// Request for sending a contact message to the Photographer
/// </summary>
public record class ContactRequest
{
    /// <summary>
    /// Name of the person sending the message
    /// </summary>
    [Required(ErrorMessage = "{0} je povinné.")]
    [Display(Name = "Jméno")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Surname of the person sending the message
    /// </summary>
    [Required(ErrorMessage = "{0} je povinné.")]
    [Display(Name = "Příjmení")]
    public string Surname { get; set; } = string.Empty;

    /// <summary>
    /// Email address of the person sending the message
    /// </summary>
    [Required(ErrorMessage = "{0} je povinná.")]
    [EmailAddress(ErrorMessage = "Neplatný formát e-mailové adresy.")]
    [Display(Name = "E-mailová adresa")]
    public string Email { get; set; } = string.Empty;

    /// <summary>
    /// Phone number of the person sending the message
    /// </summary>
    [Required(ErrorMessage = "{0} je povinné.")]
    [Phone(ErrorMessage = "Neplatný formát telefonního čísla.")]
    [Display(Name = "Telefonní číslo")]
    public string Phone { get; set; } = string.Empty;

    /// <summary>
    /// Message to be sent to the Photographer
    /// </summary>
    [Required(ErrorMessage = "{0} je povinná.")]
    [Display(Name = "zpráva")]
    public string Message { get; set; } = string.Empty;
}