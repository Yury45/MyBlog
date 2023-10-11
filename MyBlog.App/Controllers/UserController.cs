using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlog.BLL.ViewModels.Users.Request;
using MyBlog.Data.Models.Users;

namespace MyBlog.App.Controllers
{    /// <summary>
     /// Контроллер регистрации пользователя
     /// </summary>
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [Route("Register")]
        [HttpGet]
        public IActionResult Register()
        {
            return View("Register");
        }

        [Route("RegisterPart2")]
        [HttpGet]
        public IActionResult RegisterPart2(RegisterUserViewModel model)
        {
            return View("RegisterPart2", model);
        }
    }
}
