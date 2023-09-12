using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Contracts;
using Dashboard.Contracts.Post;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Post.Repositories;

/// <inheritdoc cref="IPostRepository"/>
public class PostRepository : IPostRepository
{
    private readonly IRepository<Domain.Posts.Post> _repository;

    /// <inheritdoc />
    public PostRepository(IRepository<Domain.Posts.Post> repository)
    {
        _repository = repository;
    }

    /// <inheritdoc />
    public async Task<Guid> CreateAsync(Domain.Posts.Post model, CancellationToken cancellationToken)
    {
        await _repository.AddAsync(model);
        return model.Id;
    }

    /// <inheritdoc />
    public Task<Domain.Posts.Post> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return _repository.GetByIdAsync(id, cancellationToken);
    }

    /*private readonly List<Domain.Posts.Post> _posts = new();

    /// <inheritdoc />
    public Task<PostDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return Task.Run(() => new PostDto
        {
            Id = Guid.NewGuid(),
            Title = "Тестовое объявление",
            Description = "Описание.",
            CategoryName = "Книги",
            TagNames = new []{"фентези","ЛитРПГ"},
            Price = 500.43M

        }, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Guid> CreateAsync(Domain.Posts.Post model, CancellationToken cancellationToken)
    {
        model.Id = Guid.NewGuid();
        _posts.Add(model);
        return Task.Run(() => model.Id);
    }*/
}