using Dashboard.Application.AppServices.Contexts.Repositories;
using Dashboard.Contracts.Attachment;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Repositories;

public class TagRepository : ITagRepository
{
    public Task<TagDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return Task.Run(() => new TagDto
        {
            Id = Guid.NewGuid(),
            Title = "Тестовый Тег",
        }, cancellationToken);
    }
}