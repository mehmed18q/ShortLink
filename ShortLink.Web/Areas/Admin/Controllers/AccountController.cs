using Microsoft.AspNetCore.Mvc;
using ShortLink.Application.Interfaces;
using System.Threading.Tasks;

namespace ShortLink.Web.Areas.Admin.Controllers
{
    public class AccountController : AdminBaseController
    {
        #region Constractor
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        #endregion

        #region User List
        [HttpGet("user-list")]
        public async Task<IActionResult> Index()
        {
            return View();
        }
        #endregion
    }
}
