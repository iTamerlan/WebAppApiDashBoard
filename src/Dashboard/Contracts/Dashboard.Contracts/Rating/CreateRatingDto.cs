using Dashboard.Contracts.Base;
using Dashboard.Contracts.Comment;
using System.ComponentModel.DataAnnotations;

namespace Dashboard.Contracts.Rating;

/// <summary>
/// Рейтинг.
/// </summary>
public class CreateRatingDto : BaseDto
{
    /// <summary>
    /// Значение рейтинга.
    /// </summary>
    [Range(0, 5, ErrorMessage = "Поле {0} должно быть больше {2} и меньше {1}")]
    public int Rating { get; set; }
}