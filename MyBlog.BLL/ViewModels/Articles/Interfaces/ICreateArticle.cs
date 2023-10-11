using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BLL.ViewModels.Articles.Interfaces
{
    /// <summary>
    /// Интерфейс создания статьи
    /// </summary>
    public interface ICreateArticle
    {
        int UserId { get; set; }
    }
}
