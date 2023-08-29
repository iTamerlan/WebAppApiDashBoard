using Dashboard.Contracts.Base;
using Dashboard.Contracts.Image;

namespace Dashboard.Contracts.Content;

/// <summary>
/// Блок контента.
/// </summary>
public class ContentDto : BaseDto
{
    /// <summary>
    /// Текстовый блок.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Изображение (необязательное).
    /// </summary>
    public IReadOnlyCollection<ImageDto> Image { get; set; }
    /// <summary>
    /// Номер по порядку.
    /// </summary>
    public int Number { get; set; }
}
