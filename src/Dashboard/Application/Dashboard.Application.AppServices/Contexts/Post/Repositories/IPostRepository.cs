using Dashboard.Contracts.Post;

namespace Dashboard.Application.AppServices.Contexts.Post.Repositories;

/// <summary>
/// Репозиторий для работы с объявлениями.
/// </summary>
public interface IPostRepository
{
    /// <summary>
    /// Возвращает объявление по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор объявления.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель объявления <see cref="Domain.Posts.Post"/></returns>
    Task<Domain.Posts.Post> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    /// <summary>
    /// Создает объявление по модели.
    /// </summary>
    /// <param name="model">Модель объявления.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Идентификатор созданной сущности</returns>
    Task<Guid> CreateAsync(Domain.Posts.Post model, CancellationToken cancellationToken);
}