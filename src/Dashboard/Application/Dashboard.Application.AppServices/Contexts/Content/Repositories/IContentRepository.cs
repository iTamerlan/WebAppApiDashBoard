using Dashboard.Contracts.Content;

namespace Dashboard.Application.AppServices.Contexts.Content.Repositories;

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

    /// <summary>
    /// Создает блок контента по модели.
    /// </summary>
    /// <param name="model">Модель блока контента.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Идентификатор созданной сущности</returns>
    Task<Guid> CreateAsync(Domain.Contents.BaseContent model, CancellationToken cancellationToken);
}