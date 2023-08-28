using Dashboard.Domain.Base;

namespace Dashboard.Domain.PostExts;

/// <summary>
/// Сущность пользователя.
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

}