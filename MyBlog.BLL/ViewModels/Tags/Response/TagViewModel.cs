using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BLL.ViewModels.Tags.Response
{
    /// <summary>
    /// Модель одного тега
    /// </summary>
    public class TagViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
