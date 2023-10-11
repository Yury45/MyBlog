using MyBlog.BLL.ViewModels.Articles.Interfaces;
using MyBlog.Data.Models.Tags;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BLL.ViewModels.Articles.Request
{
    /// <summary>
    /// Модель создания статьи
    /// </summary>
    public class CreateArticleViewModel : ICreateArticle
    {
        public int UserId { get ; set ; }
        public List<Tag>? Tags { get; set; }

        public string? ArticleTags { get; set; }

        [Required(ErrorMessage = "Укажите название статьи!")]
        [Display(Name = "Заголовок")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Укажите тело статьи!")]
        [Display(Name = "Содержание")]
        public string Content { get; set; }
    }
}
