using Microsoft.AspNetCore.Mvc;
using ShortLink.Application.Interfaces;
using System.Threading.Tasks;

namespace ShortLink.Web.Areas.Admin.Controllers
{
    public class AccountController : AdminBaseController
    {
        #region constractor
        private readonly IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        #endregion

        #region user list
        [HttpGet("user-list")]
        public async Task<IActionResult> Index()
        {
            return View(await _userService.GetAllUserForShow());
        }
        #endregion
    }
}
