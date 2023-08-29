using Dashboard.Domain.Base;

namespace Dashboard.Domain.Comments;

/// <summary>
/// Сущность комментария.
/// </summary>
public class Comment : BaseEntity
{
    /// <summary>
    /// Заголовок комментария.
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// Автор комментария.
    /// </summary>
    public Guid AuthorId { get; set; }
}