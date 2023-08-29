using Dashboard.Application.AppServices.Contexts.PublicUser.Repositories;
using Dashboard.Contracts.PublicUser;

namespace Dashboard.Infrastructure.DataAccess.Contexts.PublicUser.Repositories;

public class PublicUserRepository : IPublicUserRepository
{
    public Task<PublicUserDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return Task.Run(() => new PublicUserDto
        {
            Id = Guid.NewGuid(),
            UserLogin = "TestLogin",
            UserDateCreate = "21.12.2012",
        }, cancellationToken);
    }
}