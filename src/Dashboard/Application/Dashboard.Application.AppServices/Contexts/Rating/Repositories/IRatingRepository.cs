using Dashboard.Contracts.Rating;

namespace Dashboard.Application.AppServices.Contexts.Rating.Repositories;

/// <summary>
/// Репозиторий для работы с рейтингами.
/// </summary>
public interface IRatingRepository
{
    /// <summary>
    /// Возвращает рейтинг по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор рейтинга.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель объявления <see cref="RatingDto"/></returns>
    Task<RatingDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}