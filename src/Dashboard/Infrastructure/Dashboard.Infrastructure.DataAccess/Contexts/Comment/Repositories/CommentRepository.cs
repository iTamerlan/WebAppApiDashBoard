using Dashboard.Application.AppServices.Contexts.Comment.Repositories;
using Dashboard.Contracts.Attachment;
using Dashboard.Contracts.Comment;
using Dashboard.Domain.Posts;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Comment.Repositories;

/// <inheritdoc />
public class CommentRepository : ICommentRepository
{
    private readonly List<Domain.Comments.Comment> _comment = new();
    /// <inheritdoc />
    public Task<CommentDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return Task.Run(() => new CommentDto
        {
            Id = Guid.NewGuid(),
            Title = "Тестовый заголовок коммента",
        }, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Guid> CreateAsync(Domain.Comments.Comment model, CancellationToken cancellationToken)
    {
        model.Id = Guid.NewGuid();
        _comment.Add(model);
        return Task.Run(() => model.Id);
    }
}