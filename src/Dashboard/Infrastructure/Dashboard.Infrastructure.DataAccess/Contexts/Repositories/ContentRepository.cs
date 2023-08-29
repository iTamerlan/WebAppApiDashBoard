using Dashboard.Application.AppServices.Contexts.Repositories;
using Dashboard.Contracts.Attachment;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Repositories;

public class ContentRepository : IContentRepository
{
    public Task<ContentDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return Task.Run(() => new ContentDto
        {
            Id = Guid.NewGuid(),
            Description = "Тестовое содержимое контента или просто описание",
            Number = 5,
        }, cancellationToken) ;
    }
}