using Dashboard.Application.AppServices.Contexts.Repositories;
using Dashboard.Contracts.Attachment;

namespace Dashboard.Application.AppServices.Contexts.Services;

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
}