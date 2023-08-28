using Dashboard.Application.AppServices.Contexts.Repositories;
using Dashboard.Contracts;
using Dashboard.Contracts.Attachment;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Repositories;

public class CommentRepository : ICommentRepository
{
    public Task<CommentDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return Task.Run(() => new CommentDto
        {
            Id = Guid.NewGuid(),
            Title = "Тестовый заголовок коммента",
        }, cancellationToken);
    }
}