using ShortLink.Domain.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace ShortLink.Domain.Models.Account
{
    public class User : BaseEntity
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

        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(20, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string MobileActiveCode { get; set; }

        [Display(Name = "Mobile is Active")]
        public bool IsMobileActive { get; set; }

        [Display(Name = "Is Blocked")]
        public bool IsBlocked { get; set; }

        [Display(Name = "Is Admin")]
        public bool IsAdmin { get; set; }
    }
}