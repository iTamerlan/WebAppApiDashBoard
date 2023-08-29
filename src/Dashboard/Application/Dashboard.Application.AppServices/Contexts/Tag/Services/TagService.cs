using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Application.AppServices.Contexts.Tag.Repositories;
using Dashboard.Contracts.Post;
using Dashboard.Contracts.Tag;

namespace Dashboard.Application.AppServices.Contexts.Tag.Services;

/// <inheritdoc />
public class TagService : ITagService
{
    private readonly ITagRepository _tagRepository;

    /// <summary>
    /// Инициализирует экзепляр <see cref="TagService"/>
    /// </summary>
    /// <param name="tagRepository">Репозиторий для работы с тегами.</param>
    public TagService(ITagRepository tagRepository)
    {
        _tagRepository = tagRepository;
    }

    /// <inheritdoc />
    public Task<TagDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return _tagRepository.GetByIdAsync(id, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Guid> CreateAsync(CreateTagDto model, CancellationToken cancellationToken)
    {
        var post = new Domain.Tags.Tag()
        {
            Title = model.Title,
        };

        return _tagRepository.CreateAsync(post, cancellationToken);
    }
}