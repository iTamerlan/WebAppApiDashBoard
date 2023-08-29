using Dashboard.Contracts.Base;
using Dashboard.Contracts.PublicUser;
using System.ComponentModel.DataAnnotations;

namespace Dashboard.Contracts.Image;

/// <summary>
/// Изображение.
/// </summary>
public class CreateImageDto
{
    /// <summary>
    /// Описание изображения.
    /// </summary>
    public string DescriptionImage { get; set; }
    /// <summary>
    /// Дата загрузки.
    /// </summary>
    [Range(typeof(DateTime), "01.01.2000", "01.01.2120", ErrorMessage = "Дата от 01.01.2000 до 01.01.2120")]
    public DateTime DateUpload { get; set; }
    /// <summary>
    /// Адрес изображения.
    /// </summary>
    [Url(ErrorMessage = "Некорректный URL-адрес")]
    public string UrlImage { get; set; }
    /// <summary>
    /// Приватность изображения.
    /// </summary>
    public string Private { get; set; }
    /// <summary>
    /// Категория изображений.
    /// </summary>
    public Guid CategoryId { get; set; }
}