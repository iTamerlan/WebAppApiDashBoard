using Dashboard.Contracts.Base;
using Dashboard.Contracts.PublicUser;

namespace Dashboard.Contracts.Tag;

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