using Microsoft.AspNetCore.Mvc;
using ShortLink.Application.DTOs.Link;
using ShortLink.Application.Interfaces;
using System;
using System.Threading.Tasks;

namespace ShortLink.Web.Controllers
{
    public class HomeController : SiteBaseController
    {
        #region constractor
        private readonly ILinkService _linkService;
        public HomeController(ILinkService linkService)
        {
            _linkService = linkService;
        }
        #endregion
        
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(UrlRequestDTO urlRequest)
        {
            if (ModelState.IsValid)
            {
                if (urlRequest.OrginalUrl.Contains("https://") || urlRequest.OrginalUrl.Contains("http://"))
                {
                    var url = new Uri(urlRequest.OrginalUrl);
                    var shortUrl = _linkService.QuickShortUrl(url);

                    var result = await _linkService.AddLink(shortUrl);
                    switch (result)
                    {
                        case UrlRequestResult.Error:
                            TempData[ErrorMessage] = "A problem has occurred";
                            break;
                        case UrlRequestResult.Success:
                            TempData[SuccessMessage] = "Your link has been shortened successfully";
                            ViewBag.isSuccess = true;
                            ViewBag.UserShortLink = shortUrl.Value.ToString();
                            break;
                    }
                }
                else
                {
                    TempData[ErrorMessage] = "Please enter the link with HTTPs or HTTP";
                    return View(urlRequest);
                }
            }

            return View(urlRequest);
        }
    }
}