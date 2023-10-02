using System.ComponentModel.DataAnnotations;

namespace MyBlog.App.ViewModels.User
{
    /// <summary>
    /// Модель представления страницы авторизации
    /// </summary>
    public class LoginUserViewModel
    {   
        [Required(ErrorMessage = "Поле обязательно для заполнения!")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email", Prompt = "Введите Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения!")]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль", Prompt = "Введите Password")]
        public string Password { get; set; }

        public string? ReturnUrl { get; set; }
    }
}
