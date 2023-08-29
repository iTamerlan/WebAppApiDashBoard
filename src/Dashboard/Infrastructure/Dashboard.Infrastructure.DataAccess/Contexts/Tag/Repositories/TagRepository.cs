using Dashboard.Application.AppServices.Contexts.Tag.Repositories;
using Dashboard.Contracts.Tag;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Tag.Repositories;

/// <inheritdoc />
public class TagRepository : ITagRepository
{
    private readonly List<Domain.Tags.Tag> _tags = new();

    /// <inheritdoc />
    public Task<TagDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return Task.Run(() => new TagDto
        {
            Id = Guid.NewGuid(),
            Title = "Тестовый Тег",
        }, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Guid> CreateAsync(Domain.Tags.Tag model, CancellationToken cancellationToken)
    {
        model.Id = Guid.NewGuid();
        _tags.Add(model);
        return Task.Run(() => model.Id);
    }
}