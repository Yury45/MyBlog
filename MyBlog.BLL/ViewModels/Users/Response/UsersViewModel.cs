using MyBlog.Data.Models.Users;

namespace MyBlog.BLL.ViewModels.Users.Response
{
    /// <summary>
    /// Модель списка пользователей
    /// </summary>
    public class UsersViewModel
    {
        public List<MyBlog.Data.Models.Users.User> Users { get; set; } = new List<Data.Models.Users.User>();
    }
}
