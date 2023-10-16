using MyBlog.BLL.ViewModels.Tags.Response;
using System.ComponentModel.DataAnnotations;

namespace MyBlog.BLL.ViewModels.Comments.Request
{
    /// <summary>
    /// Модель обновления комментария
    /// </summary>
    public class EditCommentViewModel 
    {
        public int Id { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Заголовок", Prompt = "Заголовок")]
        public string? Title { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Содержание", Prompt = "Содержание")]
        public string? Content { get; set; }

        [Display(Name = "Теги", Prompt = "Теги")]
        public List<TagViewModel>? Tags { get; set; }
    }
}
