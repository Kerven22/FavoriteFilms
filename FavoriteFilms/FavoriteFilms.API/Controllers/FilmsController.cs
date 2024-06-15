using FavoriteFilims.API.Models.Responsies;
using FavoriteFilims.Domain.UseCases.GetFilms;
using Microsoft.AspNetCore.Mvc;

namespace FavoriteFilims.API.Controllers
{
    public class FilmsController : Controller
    {

        [ProducesResponseType(200, Type = typeof(IEnumerable<FilmResponse>))]
        public async Task<ActionResult> GetFilms(
            [FromServices] IGetFilmsUseCase useCase,
            CancellationToken cancellationToken)
        {
            var films = await useCase.Execute(cancellationToken);
            return View(films.Select(f => new FilmResponse()
            {
                Id = f.Id,
                Title = f.Title
            }));
        }
    }
}
