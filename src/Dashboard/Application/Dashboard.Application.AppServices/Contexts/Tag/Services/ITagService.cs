using Dashboard.Contracts.Post;
using Dashboard.Contracts.Tag;

namespace Dashboard.Application.AppServices.Contexts.Tag.Services;

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

    /// <summary>
    /// Создает тег по модели.
    /// </summary>
    /// <param name="model">Модель тега.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Идентификатор созданной сущности</returns>
    Task<Guid> CreateAsync(CreateTagDto model, CancellationToken cancellationToken);
}