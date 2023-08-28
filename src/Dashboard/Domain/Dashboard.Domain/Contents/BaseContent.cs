using Dashboard.Domain.Base;

namespace Dashboard.Domain.Comments;

/// <summary>
/// Сущность комментария.
/// </summary>
public class BaseContent : BaseEntity
{
    /// <summary>
    /// Описание/текст.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Принадлежность к комментарию.
    /// </summary>
    public Guid CommentId { get; set; }
    /// <summary>
    /// Прикрепленное изображение.
    /// </summary>
    public Guid ImageId { get; set; }
    /// <summary>
    /// Предшествующий блок контента.
    /// </summary>
    public Guid PreviousContentId { get; set; }
    /// <summary>
    /// Дата создания блока контента.
    /// </summary>
    public Guid DateCreate { get; set; }
}