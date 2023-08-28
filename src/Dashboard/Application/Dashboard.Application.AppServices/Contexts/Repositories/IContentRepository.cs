using Dashboard.Contracts.Attachment;

namespace Dashboard.Application.AppServices.Contexts.Repositories;

/// <summary>
/// Репозиторий для работы с блоком контента.
/// </summary>
public interface IContentRepository
{
    /// <summary>
    /// Возвращает блок контента по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор блока контента.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель объявления <see cref="ContentDto"/></returns>
    Task<ContentDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}