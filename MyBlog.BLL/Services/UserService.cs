using AutoMapper;
using Microsoft.AspNetCore.Identity;
using MyBlog.BLL.Services.Interfaces;
using MyBlog.BLL.ViewModels.Users.Request;
using MyBlog.Data.Models.Users;


namespace MyBlog.BLL.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;

        public UserService(UserManager<User> userManager, IMapper mapper, IRoleService roleService)
        {
            _userManager = userManager;
            _mapper = mapper;
            _roleService = roleService;
        }

        public Task<IdentityResult> CreateUserAsync(CreateUserViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task DeleteUserAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> EditUserAsync(EditUserViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task<EditUserViewModel> EditUserAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<User> GetuserAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>> GetUsersAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Microsoft.AspNetCore.Identity.SignInResult> LoginUserAsync(LoginUserViewModel model)
        {
            throw new NotImplementedException();
        }

        public Task LogoutUserAccount()
        {
            throw new NotImplementedException();
        }

        public Task<IdentityResult> RegisterUserAsync(RegisterUserViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
