using System.ComponentModel.DataAnnotations;

namespace ProductsCatalog.Presentaion.View_Models.User
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(maximumLength: 100, MinimumLength = 3, ErrorMessage = "First Name can't be longer than 100 characters.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required.")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is required.")]
        [Compare("Password", ErrorMessage = "Password and Confirm Password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
