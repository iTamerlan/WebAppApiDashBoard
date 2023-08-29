using Dashboard.Application.AppServices.Contexts.Content.Repositories;
using Dashboard.Contracts.Content;
using Dashboard.Domain.Posts;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Content.Repositories;

/// <inheritdoc />
public class ContentRepository : IContentRepository
{
    private readonly List<Domain.Contents.BaseContent> _content = new();

    /// <inheritdoc />
    public Task<ContentDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return Task.Run(() => new ContentDto
        {
            Id = Guid.NewGuid(),
            Description = "Тестовое содержимое контента или просто описание",
            Number = 5,
        }, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Guid> CreateAsync(Domain.Contents.BaseContent model, CancellationToken cancellationToken)
    {
        model.Id = Guid.NewGuid();
        _content.Add(model);
        return Task.Run(() => model.Id);
    }
}