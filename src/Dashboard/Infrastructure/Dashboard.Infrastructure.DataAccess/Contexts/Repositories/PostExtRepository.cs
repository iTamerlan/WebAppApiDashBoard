using Dashboard.Application.AppServices.Contexts.Repositories;
using Dashboard.Contracts;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Repositories;

public class PostExtRepository : IPostExtRepository
{
    public Task<PostExtDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return Task.Run(() => new PostExtDto
        {
            Id = Guid.NewGuid(),
            CategoryName = "Android",
            Price = 15,
            Title = "Тестовый заголовок расширенного репозитория",
        }, cancellationToken);
    }
}