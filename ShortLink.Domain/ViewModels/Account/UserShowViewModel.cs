using System.ComponentModel.DataAnnotations;


namespace ShortLink.Domain.ViewModels.Account
{
    public class UserShowViewModel
    {
        [Display(Name = "User ID")]
        public long UserID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Phone Number")]
        public string Mobile { get; set; }

        [Display(Name = "Is Blocked")]
        public bool IsBlocked { get; set; }

        [Display(Name = "Is Admin")]
        public bool IsAdmin { get; set; }
    }
}