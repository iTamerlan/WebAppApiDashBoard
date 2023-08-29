using Dashboard.Contracts.Base;
using Dashboard.Contracts.Comment;
using Dashboard.Contracts.PublicUser;

namespace Dashboard.Contracts.Rating;

/// <summary>
/// Рейтинг.
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