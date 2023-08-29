using Dashboard.Domain.Base;

namespace Dashboard.Domain.Ratings;

/// <summary>
/// Сущность рейтинга.
/// </summary>
public class Rating : BaseEntity
{
    /// <summary>
    /// К какому комментарию поставлена оценка.
    /// </summary>
    public Guid CommentId { get; set; }
    /// <summary>
    /// Какой пользователь поставил оценку.
    /// </summary>
    public Guid UserId { get; set; }
    /// <summary>
    /// Значение рейтинга.
    /// </summary>
    public int RatingValue { get; set; }
}