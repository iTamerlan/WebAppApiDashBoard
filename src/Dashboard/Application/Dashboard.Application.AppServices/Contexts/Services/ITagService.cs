using Dashboard.Contracts.Attachment;

namespace Dashboard.Application.AppServices.Contexts.Services;

/// <summary>
/// Репозиторий для работы с тегами.
/// </summary>
public interface ITagService
{
    /// <summary>
    /// Возвращает тег по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор тега.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель объявления <see cref="TagDto"/></returns>
    Task<TagDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}