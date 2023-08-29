﻿using Dashboard.Application.AppServices.Contexts.Repositories;
using Dashboard.Contracts;
using Dashboard.Contracts.Attachment;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Repositories;

public class RatingRepository : IRatingRepository
{
    public Task<RatingDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return Task.Run(() => new RatingDto
        {
            Id = Guid.NewGuid(),
            Rating = 4,
        }, cancellationToken);
    }
}