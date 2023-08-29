using Dashboard.Application.AppServices.Contexts.PostExt.Repositories;
using Dashboard.Contracts.PostExt;

namespace Dashboard.Infrastructure.DataAccess.Contexts.PostExt.Repositories;

/// <inheritdoc />
public class PostExtRepository : IPostExtRepository
{
    private readonly List<Domain.PostExts.PostExt> _postExts = new();

    /// <inheritdoc />
    public Task<PostExtDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return Task.Run(() => new PostExtDto
        {
            Id = Guid.NewGuid(),
            CategoryName = "Android",
            Price = 15,
            Title = "Тестовый заголовок расширенного репозитория",
        }, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Guid> CreateAsync(Domain.PostExts.PostExt model, CancellationToken cancellationToken)
    {
        model.Id = Guid.NewGuid();
        _postExts.Add(model);
        return Task.Run(() => model.Id);
    }
}