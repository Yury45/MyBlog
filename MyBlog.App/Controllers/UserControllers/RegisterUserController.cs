using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyBlog.App.ViewModels.User;
using MyBlog.Data.Models.Users;

namespace MyBlog.App.Controllers.UserControllers
{    /// <summary>
     /// Контроллер регистрации пользователя
     /// </summary>
    public class RegisterUserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public RegisterUserController(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [Route("Register")]
        [HttpGet]
        public IActionResult Register()
        {
            return View("Home/Register");
        }

        [Route("RegisterPart2")]
        [HttpGet]
        public IActionResult RegisterPart2(RegisterUserViewModel model)
        {
            return View("RegisterPart2", model);
        }
    }
}
