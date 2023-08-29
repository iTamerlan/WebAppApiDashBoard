using Dashboard.Application.AppServices.Contexts.Comment.Repositories;
using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Contracts.Comment;
using Dashboard.Contracts.Post;

namespace Dashboard.Application.AppServices.Contexts.Comment.Services;

/// <inheritdoc />
public class CommentService : ICommentService
{
    private readonly ICommentRepository _commentRepository;

    /// <summary>
    /// Инициализирует экзепляр <see cref="CommentService"/>
    /// </summary>
    /// <param name="commentRepository">Репозиторий для работы с комментариями.</param>
    public CommentService(ICommentRepository commentRepository)
    {
        _commentRepository = commentRepository;
    }

    /// <inheritdoc />
    public Task<CommentDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return _commentRepository.GetByIdAsync(id, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Guid> CreateAsync(CreateCommentDto model, CancellationToken cancellationToken)
    {
        var comment = new Domain.Comments.Comment()
        {
            Title = model.Title,
        };

        return _commentRepository.CreateAsync(comment, cancellationToken);
    }
}