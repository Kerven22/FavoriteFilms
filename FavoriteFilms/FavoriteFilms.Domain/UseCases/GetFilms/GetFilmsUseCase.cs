using FavoriteFilims.Domain.Models;
using FavoriteFilms.Storage;
using Microsoft.EntityFrameworkCore;

namespace FavoriteFilims.Domain.UseCases.GetFilms
{
    public class GetFilmsUseCase : IGetFilmsUseCase
    {
        private readonly FilimDbContext filimDbContext;

        public GetFilmsUseCase(FilimDbContext filimDbContext)
        {
            this.filimDbContext = filimDbContext;
        }


        public async Task<IEnumerable<Filim>> Execute(CancellationToken cancellationToken)
        {
            return await filimDbContext.Filims
                .Select(f=>new Filim()
                {
                    Id = f.FilimId, 
                    Title = f.Title
                })
                .ToArrayAsync(cancellationToken);
        }
    }
}
