using ShortLink.Domain.Models.Common;
using System.ComponentModel.DataAnnotations;

namespace ShortLink.Domain.Models.Link
{
    public class Device : BaseEntity
    {
        [Display(Name = "")]
        public bool IsBot { get; set; }

        [Display(Name = "")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(200, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string Brand { get; set; }

        [Display(Name = "")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(200, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string Family { get; set; }

        [Display(Name = "")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(200, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string Model { get; set; }
    }
}