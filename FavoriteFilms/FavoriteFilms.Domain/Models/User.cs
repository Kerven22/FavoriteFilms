using FavoriteFilims.Domain.UseCases.CreateUserUseCase;

namespace FavoriteFilims.Domain.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
    }
}
