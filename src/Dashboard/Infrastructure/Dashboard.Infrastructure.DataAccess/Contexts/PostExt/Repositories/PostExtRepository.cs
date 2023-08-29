using Dashboard.Application.AppServices.Contexts.PostExt.Repositories;
using Dashboard.Contracts.PostExt;

namespace Dashboard.Infrastructure.DataAccess.Contexts.PostExt.Repositories;

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