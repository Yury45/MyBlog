using MyBlog.Data.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Repositories
{
    public class UserRepository : Repository<User>
    {
        public UserRepository(BlogDbContext context) : base(context)
        {
        }
    }
}
