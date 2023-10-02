using MyBlog.Data.Models.Comments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Repositories
{
    public class RoleRepository : Repository<Comment>
    {
        public RoleRepository(BlogDbContext context) : base(context)
        {
        }


    }
}
