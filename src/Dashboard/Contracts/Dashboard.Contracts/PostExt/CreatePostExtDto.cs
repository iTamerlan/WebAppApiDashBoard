using Dashboard.Contracts.Base;
using Dashboard.Contracts.Comment;
using Dashboard.Contracts.Tag;

namespace Dashboard.Contracts.PostExt;

/// <summary>
/// Расширенное объявление.
/// </summary>
public class CreatePostExtDto : CreateCommentDto
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