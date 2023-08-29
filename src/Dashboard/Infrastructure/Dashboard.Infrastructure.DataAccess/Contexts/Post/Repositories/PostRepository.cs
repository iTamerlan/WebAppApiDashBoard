using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Contracts.Post;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Post.Repositories;

/// <inheritdoc />
public class PostRepository : IPostRepository
{
    private readonly List<Domain.Posts.Post> _posts = new();

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
    }
}