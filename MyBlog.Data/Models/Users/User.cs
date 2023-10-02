using Microsoft.AspNetCore.Identity;
using MyBlog.Data.Models.Articles;
using MyBlog.Data.Models.Comments;
using MyBlog.Data.Models.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.Models.Users
{
    /// <summary>
    /// Сущность пользователя
    /// </summary>
    public class User : IdentityUser<Guid>
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Login {  get; set; }
        public DateTime BirthDate { get; set; }
        public string Email {  get; set; }
        public string Password { get; set; }
        public string Photo {  get; set; }

        public List<Article> Articles { get; set; }
        public List<Comment> Comments { get; set; }
        public List<Role> Roles { get; set; }

        public User()
        {
            Photo = "https://thispersondoesnotexist.com/";
        }
    }
}
