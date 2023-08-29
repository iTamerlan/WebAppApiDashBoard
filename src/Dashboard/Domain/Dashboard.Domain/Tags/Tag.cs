using Dashboard.Domain.Base;

namespace Dashboard.Domain.Tags;

/// <summary>
/// Сущность тега.
/// </summary>
public class Tag: BaseEntity
{
    /// <summary>
    /// Название тега.
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// Тег общий или пользовательский.
    /// </summary>
    public Guid UserId { get; set; }
}