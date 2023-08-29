using Dashboard.Contracts.Content;
using Dashboard.Contracts.Post;

namespace Dashboard.Application.AppServices.Contexts.Content.Services;

/// <summary>
/// Репозиторий для работы с блоком контента.
/// </summary>
public interface IContentService
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
    Task<Guid> CreateAsync(CreateContentDto model, CancellationToken cancellationToken);
}