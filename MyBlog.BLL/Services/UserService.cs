using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyBlog.BLL.Services.Interfaces;
using MyBlog.BLL.ViewModels.Roles.Response;
using MyBlog.BLL.ViewModels.Users.Request;
using MyBlog.Data.Models.Roles;
using MyBlog.Data.Models.Users;

namespace MyBlog.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userService;
        private readonly SignInManager<User> _signInService;
        private readonly RoleManager<Role> _roleService;
        private readonly IMapper _mapper;

        public UserService(UserManager<User> userManager, IMapper mapper, RoleManager<Role> roleService, SignInManager<User> signInManager)
        {
            _userService = userManager;
            _mapper = mapper;
            _roleService = roleService;
            _signInService = signInManager;
        }

        public async Task<IdentityResult> CreateUserAsync(CreateUserViewModel model)
        {
            var user = new User();
            if (model.Firstname != null)
            {
                user.Firstname = model.Firstname;
            }
            if (model.Lastname != null)
            {
                user.Lastname = model.Lastname;
            }
            if (model.Email != null)
            {
                user.Email = model.Email;
            }
            if (model.Login != null)
            {
                user.UserName = model.Login;
            }
            var userRole = new Role() { Name = "Пользователь", Description = "Стандартный набор возможностей" };
            var result = await _userService.CreateAsync(user, model.Password);
            await _userService.AddToRoleAsync(user, userRole.Name);
            return result;
        }

        public async Task DeleteUserAsync(int id)
        {
            var user = await _userService.FindByIdAsync(id.ToString());
            await _userService.DeleteAsync(user);
        }

        public async Task<IdentityResult> EditUserAsync(EditUserViewModel model)
        {
            var user = await _userService.FindByIdAsync(model.Id.ToString());
            if (model.Firstname != null)
            {
                user.Firstname = model.Firstname;
            }
            if (model.Lastname != null)
            {
                user.Lastname = model.Lastname;
            }
            if (model.Email != null)
            {
                user.Email = model.Email;
            }
            if (model.NewPassword != null)
            {
                user.PasswordHash = _userService.PasswordHasher.HashPassword(user, model.NewPassword);
            }
            if (model.Login != null)
            {
                user.UserName = model.Login;
            }
            foreach (var role in model.Roles)
            {
                var roleName = _roleService.FindByIdAsync(role.Id.ToString()).Result.Name;
                if (role.IsSelected)
                {
                    await _userService.AddToRoleAsync(user, roleName);
                }
                else
                {
                    await _userService.RemoveFromRoleAsync(user, roleName);
                }
            }
            var result = await _userService.UpdateAsync(user);
            return result;
        }

        public async Task<EditUserViewModel> EditUserAsync(int id)
        {
            var user = await _userService.FindByIdAsync(id.ToString());
            var allRolesName = _roleService.Roles.ToList();
            var model = new EditUserViewModel
            {
                Firstname = user.Firstname,
                Lastname = user.Lastname,
                Login = user.UserName,
                Email = user.Email,
                NewPassword = string.Empty,
                Id = id,
                Roles = allRolesName.Select(r => new RoleViewModel() { Id = r.Id, Name = r.Name }).ToList(),
            };
            return model;
        }

        public async Task<User> GetUserAsync(int id)
        {
            return await _userService.FindByIdAsync(id.ToString());
        }

        public async Task<List<User>> GetUsersAsync()
        {
            var users = _userService.Users
                .Include(u => u.Articles)
                .ToList();
            foreach (var user in users)
            {
                var roles = await _userService.GetRolesAsync(user);
                foreach (var role in roles)
                {
                    var newRole = new Role { Name = role };
                    user.Roles.Add(newRole);
                }
            }
            return users;
        }

        public async Task<SignInResult> LoginUserAsync(LoginUserViewModel model)
        {
            Console.WriteLine(model.Email);
            var user = await _userService.FindByEmailAsync(model.Email);
            if (user == null)
                return SignInResult.Failed;

            var result = await _signInService.PasswordSignInAsync(user, model.Password, true, false);
            return result;
        }

        public async Task LogoutUserAccount()
        {
            await _signInService.SignOutAsync();
        }

        public async Task<IdentityResult> RegisterUserAsync(RegisterUserViewModel model)
        {
            var user = _mapper.Map<User>(model);
            var result = await _userService.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                await _signInService.SignInAsync(user, false);
                var userRole = new Role() { Name = "Пользователь", Description = "Стандартная роль приложения" };
                await _roleService.CreateAsync(userRole);
                var currentUser = await _userService.FindByIdAsync(Convert.ToString(user.Id));
                await _userService.AddToRoleAsync(currentUser, userRole.Name);
                return result;
            }
            else
            {
                return result;
            }
        }
    }
}
