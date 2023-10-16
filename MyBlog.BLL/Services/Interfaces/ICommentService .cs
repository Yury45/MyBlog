using MyBlog.BLL.ViewModels.Comments.Request;
using MyBlog.Data.Models.Comments;


namespace MyBlog.BLL.Services.Interfaces
{
    public interface ICommentService
    {
        Task<Guid> CreateComment(CreateCommentViewModel model, int userId);

        Task RemoveComment(int id);

        Task<List<Comment>> GetComments();

        Task<EditCommentViewModel> EditComment(int id);

        Task EditComment(EditCommentViewModel model, int id);
    }
}
