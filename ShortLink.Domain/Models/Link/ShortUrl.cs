using ShortLink.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ShortLink.Domain.Models.Link
{
    public class ShortUrl : BaseEntity
    {
        #region properties
        [Display(Name = "Base URL")]
        [Required(ErrorMessage = "Please enter {0}")]
        public Uri OrginalUrl { get; set; }

        [Display(Name = "Full URL")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(400, ErrorMessage = "{0} cannot be more than {1} characters")]
        public Uri Value { get; set; }

        [Display(Name = "Token")]
        [Required(ErrorMessage = "Please enter {0}")]
        [MaxLength(40, ErrorMessage = "{0} cannot be more than {1} characters")]
        public string Token { get; set; }
        #endregion

        #region relations
        public ICollection<RequestUrl> RequestUrls { get; set; }
        #endregion
    }
}