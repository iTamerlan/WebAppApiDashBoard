using Dashboard.Application.AppServices.Contexts.Rating.Repositories;
using Dashboard.Contracts.Attachment;
using Dashboard.Contracts.Rating;
using Dashboard.Domain.Posts;
using Dashboard.Domain.Ratings;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Rating.Repositories;

/// <inheritdoc />
public class RatingRepository : IRatingRepository
{
    private readonly List<Domain.Ratings.Rating> _ratings = new();

    /// <inheritdoc />
    public Task<RatingDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return Task.Run(() => new RatingDto
        {
            Id = Guid.NewGuid(),
            Rating = 4,
        }, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Guid> CreateAsync(Domain.Ratings.Rating model, CancellationToken cancellationToken)
    {
        model.Id = Guid.NewGuid();
        _ratings.Add(model);
        return Task.Run(() => model.Id);
    }
}