using Dashboard.Contracts.Base;
using Dashboard.Contracts.Comment;
using Dashboard.Contracts.Tag;

namespace Dashboard.Contracts.PostExt;

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