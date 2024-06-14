using FavoriteFilims.Domain.Models;

namespace FavoriteFilims.Domain.UseCases.CreateUserUseCase
{
    public interface ICreateUserUseCase
    {
        public Task<User> Execute(CreateUserCommand createUserCommand, CancellationToken cancellationToken);
    }
}
