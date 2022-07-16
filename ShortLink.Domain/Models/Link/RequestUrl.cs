using ShortLink.Domain.Models.Common;
using System;
using System.ComponentModel.DataAnnotations;

namespace ShortLink.Domain.Models.Link
{
    public class RequestUrl : BaseEntity
    {
        #region properties
        [Display(Name = "UrlID")]
        public long ShortUrlId { get; set; }

        [Display(Name = "Requested at")]
        public DateTime RequestDataTime { get; set; }
        #endregion

        #region relations
        public ShortUrl ShortUrl { get; set; }
        #endregion
    }
}