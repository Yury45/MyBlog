using Microsoft.AspNetCore.Http;
using MyBlog.BLL.ViewModels.Roles.Request;
using MyBlog.BLL.ViewModels.Roles.Response;
using MyBlog.Data.Models.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BLL.Services.Interfaces
{
    public interface IRoleService
    {
        Task<Guid> CreateRole(CreateRoleViewModel model);

        Task EditRole(CreateRoleViewModel model);

        Task RemoveRole(int id);

        Task<List<Role>> GetRoles();

        Task<Role?> GetRole(int id);
    }
}
