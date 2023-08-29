using Dashboard.Contracts.Attachment;

namespace Dashboard.Application.AppServices.Contexts.Repositories;

/// <summary>
/// Репозиторий для работы с тегами.
/// </summary>
public interface ITagRepository
{
    /// <summary>
    /// Возвращает тег по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор тега.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель объявления <see cref="TagDto"/></returns>
    Task<TagDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}