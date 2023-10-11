using MyBlog.BLL.ViewModels.Users.Request;
using MyBlog.Data.Models.Roles;

namespace MyBlog.BLL.ViewModels.Users.Request
{
    /// <summary>
    /// Модель создания пользователя
    /// </summary>
    public class CreateUserViewModel : RegisterUserViewModel
    {
        public List<string>? Roles { get; set; } = new List<string> { "User" };
        public List<string>? AllRoles { get; set; }

        public CreateUserViewModel(List<Role> roles)
        {
            AllRoles = roles.Select(r => r.Name!).ToList();
        }

        public CreateUserViewModel() { }
    }
}
