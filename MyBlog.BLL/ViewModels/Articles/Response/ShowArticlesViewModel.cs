using MyBlog.BLL.ViewModels.Comments.Request;
using MyBlog.Data.Models.Articles;
using MyBlog.Data.Models.Comments;
using MyBlog.Data.Models.Tags;
using MyBlog.Data.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BLL.ViewModels.Articles.Response
{
    /// <summary>
    /// Модель списка статей
    /// </summary>
    public class ShowArticlesViewModel
    {
        public List<Article> Article { get; set; } = new List<Article>();
    }
}
