using Dashboard.Application.AppServices.Contexts.PostExt.Repositories;
using Dashboard.Contracts;

namespace Dashboard.Application.AppServices.Contexts.PostExt.Services;

/// <inheritdoc />
public class PostExtService : IPostExtService
{
    private readonly IPostExtRepository _postExtRepository;

    /// <summary>
    /// Инициализирует экзепляр <see cref="PostExtService"/>
    /// </summary>
    /// <param name="postExtRepository">Репозиторий для работы с расширенными объявлениями.</param>
    public PostExtService(IPostExtRepository postExtRepository)
    {
        _postExtRepository = postExtRepository;
    }

    /// <inheritdoc />
    public Task<PostExtDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return _postExtRepository.GetByIdAsync(id, cancellationToken);
    }
}