using Dashboard.Domain.Base;

namespace Dashboard.Domain.PostExts;

/// <summary>
/// Сущность расширенного объявления.
/// </summary>
public class PostExt : BaseEntity
{
    /// <summary>
    /// Наименование категории.
    /// </summary>
    public Guid CategoryId { get; set; }
    /// <summary>
    /// Цена.
    /// </summary>
    public decimal Price { get; set; }
    /// <summary>
    /// Заголовок комментария.
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// Автор комментария.
    /// </summary>
    public Guid AuthorId { get; set; }
}