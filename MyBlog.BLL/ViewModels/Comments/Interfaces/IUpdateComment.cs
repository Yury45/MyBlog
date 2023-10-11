using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BLL.ViewModels.Comments.Interfaces
{
    /// <summary>
    /// Интерфейс обновления комментария
    /// </summary>
    public interface IUpdateComment
    {
        int Id { get; set; }
        string Text { get; set; }
    }
}
