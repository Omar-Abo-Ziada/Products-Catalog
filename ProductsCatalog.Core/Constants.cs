namespace ProductsCatalog.Domain
{
    public class Constants
    {
        // Image upload constraints
        public const int MaxImageSize = 1 * 1024 * 1024; // 1MB
        public static readonly string[] AllowedImageTypes = { ".jpg", ".jpeg", ".png" };

        // Maximum lengths for string properties
        public const int MaxNameLength = 100;
        public const int MaxDescriptionLength = 1000;
    }
}