using Dashboard.Domain.Base;

namespace Dashboard.Domain.Images;

/// <summary>
/// Сущность изображения.
/// </summary>
public class Image : BaseEntity
{
    /// <summary>
    /// Описание изображения.
    /// </summary>
    public string DescriptionImage { get; set; }
    /// <summary>
    /// Дата загрузки.
    /// </summary>
    public string DateUpload { get; set; }
    /// <summary>
    /// Адрес изображения.
    /// </summary>
    public string UrlImage { get; set; }
    /// <summary>
    /// Какой пользователь загрузил.
    /// </summary>
    public Guid UserId { get; set; }
    /// <summary>
    /// Приватность изображения.
    /// </summary>
    public string Private { get; set; }
    /// <summary>
    /// Категория изображений.
    /// </summary>
    public Guid CategoryId { get; set; }

}