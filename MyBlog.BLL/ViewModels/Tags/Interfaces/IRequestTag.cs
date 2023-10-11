using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BLL.ViewModels.Tags.Interfaces
{
    /// <summary>
    /// Интерфейс для запроса тега
    /// </summary>
    public interface IRequestTag
    {
        string Name { get; set; }
    }
}
