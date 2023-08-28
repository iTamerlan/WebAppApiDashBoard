using Dashboard.Contracts.Attachment;
using Dashboard.Contracts.Base;


namespace Dashboard.Contracts.Attachment;

/// <summary>
/// Блок контента.
/// </summary>
public class ContentDto: BaseDto
{
    /// <summary>
    /// Описание.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Изображение.
    /// </summary>
    public IReadOnlyCollection<ImageDto> Image { get; set; }
    /// <summary>
    /// Номер по порядку.
    /// </summary>
    public int Number { get; set; }
}
