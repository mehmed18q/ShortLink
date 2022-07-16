using System.ComponentModel.DataAnnotations;

namespace ShortLink.Application.DTOs.Account
{
    public class RegisterUserDTO
    {
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(200, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string Mobile { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(200, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(200, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string LastName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(200, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string Password { get; set; }

        [Display(Name = "RePassword")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(200, ErrorMessage = "{0} cannot be more than {1} characters")]
        [Compare("Password", ErrorMessage = "Passwords are inconsistent")]
        public string RePassword { get; set; }
    }
    public enum RegisterUserResult
    {
        IsMobileExist,
        Success
    }
}