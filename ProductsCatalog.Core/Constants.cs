namespace ProductsCatalog.Domain
{
    public class Constants
    {
        // Image upload constraints
        public const int MaxImageSize = 1 * 1024 * 1024; // 1MB

        public const int MaxFileSizeLength = 1 * 1024 * 1024;

        public static readonly string[] AllowedImageTypes = { ".jpg", ".jpeg", ".png" };

        // Maximum lengths for string properties
        public const int MaxNameLength = 100;

        public const int MaxDescriptionLength = 1000;

        public const int MaxEmailLength = 100;

        public const int MaxImageUrlLength = 200;

        //--------------------------------------------------------------

        public const string SuccessMessage = "Operation successful.";

        public const string FailureMessage = "Operation failed.";
    }
}