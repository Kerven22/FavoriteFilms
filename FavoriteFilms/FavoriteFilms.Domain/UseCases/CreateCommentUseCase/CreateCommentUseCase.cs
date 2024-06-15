using FavoriteFilims.Domain.Models;

namespace FavoriteFilims.Domain.UseCases.CreateCommentUseCase
{
    public class CreateCommentUseCase : ICreateCommentUseCase  
    {
        public Task<Comment> Execute(Guid filmId, string title, Guid UserId, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
