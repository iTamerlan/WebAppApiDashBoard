using Dashboard.Application.AppServices.Contexts.Content.Repositories;
using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Contracts.Content;
using Dashboard.Contracts.Post;

namespace Dashboard.Application.AppServices.Contexts.Content.Services;

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

    /// <inheritdoc />
    public Task<Guid> CreateAsync(CreateContentDto model, CancellationToken cancellationToken)
    {
        var post = new Domain.Contents.BaseContent()
        {
            Description = model.Description,
            Number = model.Number,
        };

        return _contentRepository.CreateAsync(post, cancellationToken);
    }
}