using Dashboard.Contracts.Base;
using Dashboard.Contracts.PublicUser;
using System.ComponentModel.DataAnnotations;

namespace Dashboard.Contracts.Image;

/// <summary>
/// Изображение.
/// </summary>
public class ImageDto : BaseDto
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
    public IReadOnlyCollection<PublicUserDto> UserUpload { get; set; }
    /// <summary>
    /// Приватность изображения.
    /// </summary>
    public string Private { get; set; }
    /// <summary>
    /// Категория изображений.
    /// </summary>
    public string CategoryName { get; set; }
}
