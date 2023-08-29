using Dashboard.Contracts.Attachment;
using Dashboard.Contracts.Base;
using Dashboard.Contracts.Content;
using System.ComponentModel.DataAnnotations;

namespace Dashboard.Contracts.Comment;

/// <summary>
/// Комментарий.
/// </summary>
public class CreateCommentDto : BaseDto
{
    /// <summary>
    /// Заголовок.
    /// </summary>
    [Required]
    [StringLength(140, MinimumLength = 0, ErrorMessage = "Поле {0} должно быть по длине больше {2} и меньше {1} символов")]
    public string Title { get; set; }
}