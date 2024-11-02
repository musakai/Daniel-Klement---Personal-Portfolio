namespace Musakai.Blazor.Components.Images.ImageSlider
{
    /// <summary>
    /// Image slider content.
    /// </summary>
    public class ImageSliderContent
    {
        /// <summary>
        /// Image source in URI.
        /// </summary>
        public required string Src { get; set; }

        /// <summary>
        /// Image and slide title.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Image and slide description.
        /// </summary>
        public string? Description { get; set; }
    }
}
