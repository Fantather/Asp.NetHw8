using Asp.NetHw8.InputModels;
using Asp.NetHw8.Models;
using Asp.NetHw8.ViewModels;

namespace Asp.NetHw8.Mappers
{
    public static class CommentMappingExtensions
    {
        public static Comment ToComment(this CommentInputModel inputModel)
        {
            return new Comment(inputModel.Name, inputModel.Text);
        }

        public static CommentViewModel ToViewModel(this Comment comment)
        {
            return new CommentViewModel(comment.Name, comment.Text);
        }
    }
}
