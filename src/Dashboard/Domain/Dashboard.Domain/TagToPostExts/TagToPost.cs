using Dashboard.Domain.Base;

namespace Dashboard.Domain.Comments;

/// <summary>
/// Сущность связи тегов и постов.
/// </summary>
public class TagToPost : BaseEntity
{
    /// <summary>
    /// Идентификатор тега.
    /// </summary>
    public Guid Tag { get; set; }
    /// <summary>
    /// Идентификатор поста.
    /// </summary>
    public Guid Post { get; set; }
}
