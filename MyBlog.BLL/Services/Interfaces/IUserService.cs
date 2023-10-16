﻿using Microsoft.AspNetCore.Identity;
using MyBlog.BLL.ViewModels.Users.Request;
using MyBlog.BLL.ViewModels.Users.Response;
using MyBlog.Data.Models.Roles;
using MyBlog.Data.Models.Users;
using System.Security.Claims;

namespace MyBlog.BLL.Services.Interfaces
{
    public interface IUserService
    {
        Task<IdentityResult> RegisterUserAsync(RegisterUserViewModel model);

        Task<IdentityResult> CreateUserAsync(CreateUserViewModel model);

        Task<SignInResult> LoginUserAsync(LoginUserViewModel model);

        Task<IdentityResult> EditUserAsync(EditUserViewModel model);

        Task<EditUserViewModel> EditUserAsync(Guid id);

        Task DeleteUserAsync(Guid id);

        Task<List<User>> GetUsersAsync();

        Task<User> GetuserAsync(Guid id);

        Task LogoutUserAccount();
    }
}
