using MyBlog.BLL.ViewModels.Comments.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BLL.ViewModels.Comments.Request
{
    /// <summary>
    /// Модель обновления комментария
    /// </summary>
    public class EditCommentViewModel : IUpdateComment
    {
        public int Id { get; set; }
        public string? ReturnUrl { get; set; }

        [Required(ErrorMessage = "Укажите текст комментария!")]
        [Display(Name = "Текст комментария")]
        public string Text { get; set; }
    }
}
