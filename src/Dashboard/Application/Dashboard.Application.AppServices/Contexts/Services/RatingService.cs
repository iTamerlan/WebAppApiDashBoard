using Dashboard.Application.AppServices.Contexts.Repositories;
using Dashboard.Contracts;

namespace Dashboard.Application.AppServices.Contexts.Services;

/// <inheritdoc />
public class RatingService : IRatingService
{
    private readonly IRatingRepository _ratingRepository;

    /// <summary>
    /// Инициализирует экзепляр <see cref="RatingService"/>
    /// </summary>
    /// <param name="ratingRepository">Репозиторий для работы с рейтингами.</param>
    public RatingService(IRatingRepository ratingRepository)
    {
        _ratingRepository = ratingRepository;
    }

    /// <inheritdoc />
    public Task<RatingDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return _ratingRepository.GetByIdAsync(id, cancellationToken);
    }
}