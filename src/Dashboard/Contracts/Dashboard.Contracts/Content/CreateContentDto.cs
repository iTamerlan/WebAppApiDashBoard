using Dashboard.Contracts.Attachment;
using Dashboard.Contracts.Base;
using System.ComponentModel.DataAnnotations;


namespace Dashboard.Contracts.Content;

/// <summary>
/// Блок контента.
/// </summary>
public class CreateContentDto
{
    /// <summary>
    /// Текстовый блок.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Номер по порядку.
    /// </summary>
    [Range(0, 100, ErrorMessage = "Поле {0} должно быть больше {2} и меньше {1}")]
    public int Number { get; set; }
}
