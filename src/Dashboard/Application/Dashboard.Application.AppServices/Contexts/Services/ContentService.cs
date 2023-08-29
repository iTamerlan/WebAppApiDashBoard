using Dashboard.Application.AppServices.Contexts.Repositories;
using Dashboard.Contracts.Attachment;

namespace Dashboard.Application.AppServices.Contexts.Services;

/// <inheritdoc />
public class ContentService : IContentService
{
    private readonly IContentRepository _contentRepository;

    /// <summary>
    /// Инициализирует экзепляр <see cref="ContentService"/>
    /// </summary>
    /// <param name="contentRepository">Репозиторий для работы с блоками контента.</param>
    public ContentService(IContentRepository contentRepository)
    {
        _contentRepository = contentRepository;
    }

    /// <inheritdoc />
    public Task<ContentDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return _contentRepository.GetByIdAsync(id, cancellationToken);
    }
}