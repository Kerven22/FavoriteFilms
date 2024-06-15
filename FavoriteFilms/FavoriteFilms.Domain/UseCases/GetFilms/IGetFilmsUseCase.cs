using FavoriteFilims.Domain.Models;

namespace FavoriteFilims.Domain.UseCases.GetFilms
{
    public interface IGetFilmsUseCase
    {
        Task<IEnumerable<Filim>> Execute(CancellationToken cancellationToken);
    }
}
