using System.ComponentModel.DataAnnotations;

namespace ShortLink.Application.DTOs.Link
{
    public class UrlRequestDTO
    {
        [Display(Name = "Base URL")]
        [Required(ErrorMessage = "Please enter {0}")]
        public string OrginalUrl { get; set; }
    }
    public enum UrlRequestResult
    {
        Success,
        Error
    }
}