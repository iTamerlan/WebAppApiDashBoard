using Dashboard.Contracts.Attachment;
using Dashboard.Contracts.Base;


namespace Dashboard.Contracts.Content;

/// <summary>
/// Блок контента.
/// </summary>
public class CreateContentDto : BaseDto
{
    /// <summary>
    /// Текстовый блок.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Номер по порядку.
    /// </summary>
    public int Number { get; set; }
}
