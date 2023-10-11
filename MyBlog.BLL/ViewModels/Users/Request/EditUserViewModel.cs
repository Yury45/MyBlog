using MyBlog.BLL.ViewModels.Users.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace MyBlog.BLL.ViewModels.Users.Request
{
    /// <summary>
    /// Модель обновления пользователя
    /// </summary>
    public class EditUserViewModel : IUpdateUser
    {
        public int Id { get; set; }
        public List<string> Roles { get; set; }


        [Required(ErrorMessage = "Поле Имя обязательно для заполнения")]
        [DataType(DataType.Text)]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Отчество", Prompt = "Введите отчество")]
        public string SecondName { get; set; }

        [Required(ErrorMessage = "Поле Фамилия обязательно для заполнения")]
        [DataType(DataType.Text)]
        [Display(Name = "Фамилия")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Поле Email обязательно для заполнения")]
        [EmailAddress]
        [Display(Name = "Email", Prompt = "example.com")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Поле \"Дата рождения\" обязательно для заполнения")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Дата рождения", Prompt = "число/месяц/год")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Поле обязательно для заполнения!")]
        [Display(Name = "Никнейм")]
        public string Login { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Фото", Prompt = "Ссылка на фотографию")]
        public string Photo { get; set; }
    }
}
