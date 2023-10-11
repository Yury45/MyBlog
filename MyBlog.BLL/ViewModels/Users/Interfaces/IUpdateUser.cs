namespace MyBlog.BLL.ViewModels.Users.Interfaces
{
    /// <summary>
    /// Интерфейс обновления пользователя
    /// </summary>
    public interface IUpdateUser
    {
        public int Id { get; set; }
        public List<string> Roles { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string? LastName { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Login { get; set; }
        public string Photo { get; set; }
    }
}
