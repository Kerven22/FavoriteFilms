using FavoriteFilims.Domain.Models;

namespace FavoriteFilims.Domain.UseCases.CreateCommentUseCase
{
    public interface ICreateCommentUseCase
    {
        Task<Comment> Execute(Guid filmId, string title, Guid UserId, CancellationToken cancellationToken);
    }
}
