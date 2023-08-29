using Dashboard.Contracts.Post;
using Dashboard.Contracts.PostExt;

namespace Dashboard.Application.AppServices.Contexts.PostExt.Services;

/// <summary>
/// Репозиторий для работы с расширенными постами.
/// </summary>
public interface IPostExtService
{
    /// <summary>
    /// Возвращает расширенный пост по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор расширенный пост.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель объявления <see cref="PostExtDto"/></returns>
    Task<PostExtDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    /// <summary>
    /// Создает расширенное объявление по модели.
    /// </summary>
    /// <param name="model">Модель расширенного объявления.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Идентификатор созданной сущности</returns>
    Task<Guid> CreateAsync(CreatePostExtDto model, CancellationToken cancellationToken);
}