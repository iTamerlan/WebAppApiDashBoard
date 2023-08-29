using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Application.AppServices.Contexts.Rating.Repositories;
using Dashboard.Contracts.Post;
using Dashboard.Contracts.Rating;

namespace Dashboard.Application.AppServices.Contexts.Rating.Services;

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

    /// <inheritdoc />
    public Task<Guid> CreateAsync(CreateRatingDto model, CancellationToken cancellationToken)
    {
        var rating = new Domain.Ratings.Rating()
        {
            RatingValue = model.Rating,
        };

        return _ratingRepository.CreateAsync(rating, cancellationToken);
    }
}