using Dashboard.Contracts;

namespace Dashboard.Application.AppServices.Contexts.Rating.Services;

/// <summary>
/// Репозиторий для работы с рейтингами.
/// </summary>
public interface IRatingService
{
    /// <summary>
    /// Возвращает рейтинг по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор рейтинга.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель объявления <see cref="RatingDto"/></returns>
    Task<RatingDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}