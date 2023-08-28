using Dashboard.Contracts;

namespace Dashboard.Application.AppServices.Contexts.Repositories;

/// <summary>
/// Репозиторий для работы с комментариями.
/// </summary>
public interface ICommentRepository
{
    /// <summary>
    /// Возвращает комментарий по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор комментария.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель объявления <see cref="CommentDto"/></returns>
    Task<CommentDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}