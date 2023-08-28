using Dashboard.Contracts.Attachment;
using Dashboard.Contracts.Base;

namespace Dashboard.Contracts.Attachment;

/// <summary>
/// Тэг.
/// </summary>
public class TagDto : BaseDto
{
    /// <summary>
    /// Название тега.
    /// </summary>
    public string Title { get; set; }
    /// <summary>
    /// Тег общий или для конкретного пользователя.
    /// </summary>
    public IReadOnlyCollection<PublicUserDto> User { get; set; }
}