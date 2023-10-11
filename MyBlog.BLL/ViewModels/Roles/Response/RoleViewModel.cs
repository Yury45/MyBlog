using MyBlog.Data.Models.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BLL.ViewModels.Roles.Response
{
    /// <summary>
    /// Модель одной роли
    /// </summary>
    public class RoleViewModel
    {
        public List<Role> Roles { get; set; } = new List<Role>();
    }
}
