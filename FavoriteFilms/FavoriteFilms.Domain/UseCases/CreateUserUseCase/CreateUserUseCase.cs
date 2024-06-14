using FavoriteFilims.Domain.Models;


namespace FavoriteFilims.Domain.UseCases.CreateUserUseCase
{
    public class CreateUserUseCase : ICreateUserUseCase
    {
        public Task<User> Execute(CreateUserCommand createUserCommand, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
