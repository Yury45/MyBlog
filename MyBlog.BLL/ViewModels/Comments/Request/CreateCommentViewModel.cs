using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BLL.ViewModels.Comments.Request
{
    /// <summary>
    /// Модель создания комментария
    /// </summary>
    public class CreateCommentViewModel
    {

        [Required(ErrorMessage = "Укажите Id пользователя")]
        public int UserId { get; set; }


        [Required(ErrorMessage = "Укажите Id комментария!")]
        public int PostId { get; set; }

        [Required(ErrorMessage = "Укажите текст комментария!")]
        [Display(Name = "Текст комментария")]
        public string Text { get; set; }
    }
}
