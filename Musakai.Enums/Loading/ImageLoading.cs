namespace Musakai.Enums.Loading
{
    /// <summary>
    /// Image Loading types.
    /// </summary>
    public enum ImageLoading
    {
        /// <summary>
        /// Defers loading the image until it’s near the viewport, which can improve the initial page load time.
        /// </summary>
        Lazy,

        /// <summary>
        /// Loads the image as soon as possible, useful for images critical to the layout or user experience.
        /// </summary>
        Eager,

        /// <summary>
        /// Default value, the browser decides when to load the image.
        /// </summary>
        Auto
    }
}
