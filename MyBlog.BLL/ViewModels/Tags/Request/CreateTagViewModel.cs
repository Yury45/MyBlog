using MyBlog.BLL.ViewModels.Tags.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.BLL.ViewModels.Tags.Request
{
    /// <summary>
    /// Модель создания тега
    /// </summary>
    public class CreateTagViewModel : IRequestTag
    {
        [Required(ErrorMessage = "Укажите имя тега!")]
        [Display(Name = "Название")]
        public string Name { get ; set; }
    }
}
