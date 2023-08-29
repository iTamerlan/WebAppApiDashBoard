using Dashboard.Application.AppServices.Contexts.Repositories;
using Dashboard.Contracts;

namespace Dashboard.Application.AppServices.Contexts.Services;

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
}