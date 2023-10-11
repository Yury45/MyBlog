using Microsoft.AspNetCore.Mvc;
using MyBlog.BLL.ViewModels.Users.Interfaces;
using MyBlog.BLL.ViewModels.Users.Request;
using MyBlog.BLL.ViewModels.Users.Response;
using MyBlog.Data.Models.Roles;
using MyBlog.Data.Models.Users;
using System.Security.Claims;

namespace MyBlog.BLL.Services.Interfaces
{
    internal interface IUserService
    {
        /// <summary>
        /// Создание пользователя
        /// </summary>
        Task<(bool, User)> CreateUserAsync(RegisterUserViewModel model);

        /// <summary>
        /// Создание пользователя
        /// </summary>
        Task<bool> UpdateUserAsync(IUpdateUser model);

        /// <summary>
        /// Получение списка всех пользователей
        /// </summary>
        Task<List<User>> GetAllUsersAsync();

        /// <summary>
        /// Получение пользователя по идентификатору
        /// </summary>
        Task<User?> GetUserByIdAsync(int id);

        /// <summary>
        /// Получение пользователя по почтовому адресу
        /// </summary>
        Task<User?> GetUserByEmailAsync(string email);

        /// <summary>
        /// Получение пользователя по имени
        /// </summary>
        Task<User?> GetUserByNameAsync(string name);

        /// <summary>
        /// Удаление пользователя (основное приложение)
        /// </summary>
        Task<bool> DeleteByIdAsync(int id, int? userId, bool fullAccess);

        /// <summary>
        /// Удаление пользователя (API)
        /// </summary>
        Task<bool> DeleteByIdAsync(User user);

        /// <summary>
        /// Получение утверждений пользователя (роли, идентификатор)
        /// </summary>
        Task<List<Claim>> GetUserClaimsAsync(User user);

        /// <summary>
        /// Получение модели редактирования пользователя
        /// </summary>
        Task<(EditUserViewModel?, IActionResult?)> GetUserEditViewModelAsync(int id, string? userId, bool fullAccess);

        /// <summary>
        /// Получение модели всех пользователей
        /// </summary>
        Task<UsersViewModel?> GetUsersViewModelAsync(int? roleId);

        /// <summary>
        /// Получение модели профиля пользователя
        /// </summary>
        Task<UserViewModel?> GetUserViewModelAsync(int id);
    }
}
