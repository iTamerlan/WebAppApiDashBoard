using Dashboard.Contracts.Base;
using Dashboard.Contracts.PublicUser;

namespace Dashboard.Contracts.Tag;

/// <summary>
/// Тэг.
/// </summary>
public class CreateTagDto : BaseDto
{
    /// <summary>
    /// Название тега.
    /// </summary>
    public string Title { get; set; }
}