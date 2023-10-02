using MyBlog.Data.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Models.Roles
{
    /// <summary>
    /// Сущность роли пользователя
    /// </summary>
    public class Role
    {
        public int Id { get; set; }
        public string Description {  get; set; }

        public List<User> Users { get; set; }

    }
}
