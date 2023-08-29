using Dashboard.Contracts.Attachment;
using Dashboard.Contracts.Base;

namespace Dashboard.Contracts;

/// <summary>
/// Комментарий.
/// </summary>
public class RatingDto : BaseDto
{
    /// <summary>
    /// К какому комментарию.
    /// </summary>
    public IReadOnlyCollection<CommentDto> Comment { get; set; }
    /// <summary>
    /// Автор.
    /// </summary>
    public IReadOnlyCollection<PublicUserDto> Author { get; set; }
    /// <summary>
    /// Значение рейтинга.
    /// </summary>
    public int Rating { get; set; }
}