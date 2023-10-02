using MyBlog.Data.Models.Comments;
using MyBlog.Data.Models.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Repositories
{
    public class RoleRepository : Repository<Role>
    {
        public RoleRepository(BlogDbContext context) : base(context)
        {
        }


    }
}
