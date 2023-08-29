using Dashboard.Contracts.Comment;

namespace Dashboard.Application.AppServices.Contexts.Comment.Services;

/// <summary>
/// Репозиторий для работы с комментариями.
/// </summary>
public interface ICommentService
{
    /// <summary>
    /// Возвращает комментарий по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор комментария.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель объявления <see cref="CommentDto"/></returns>
    Task<CommentDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);

    /// <summary>
    /// Создает комментарий по модели.
    /// </summary>
    /// <param name="model">Модель комментария.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Идентификатор созданной сущности</returns>
    Task<Guid> CreateAsync(CreateCommentDto model, CancellationToken cancellationToken);
}