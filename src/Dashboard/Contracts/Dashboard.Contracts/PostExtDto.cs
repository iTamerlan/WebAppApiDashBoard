using Dashboard.Contracts.Attachment;
using Dashboard.Contracts.Base;

namespace Dashboard.Contracts;

/// <summary>
/// Расширенное объявление.
/// </summary>
public class PostExtDto : CommentDto
{
    /// <summary>
    /// Наименование категории.
    /// </summary>
    public string CategoryName { get; set; }
    /// <summary>
    /// Список тегов.
    /// </summary>
    public IReadOnlyCollection<TagDto> Tags { get; set; }
    /// <summary>
    /// Цена.
    /// </summary>
    public decimal Price { get; set; }

}