using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BLL.ViewModels.Articles.Interfaces
{
    /// <summary>
    /// Интерфейс для запроса статьи
    /// </summary>
    public interface IRequestArticle
    {
        string? Tags { get; set; }
        string Title { get; set; }
        string Content { get; set; }
    }
}
