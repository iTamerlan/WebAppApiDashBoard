using Dashboard.Application.AppServices.Contexts.Repositories;
using Dashboard.Contracts.Attachment;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Repositories;

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