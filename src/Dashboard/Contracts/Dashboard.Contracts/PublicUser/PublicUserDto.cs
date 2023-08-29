using Dashboard.Contracts.Base;

namespace Dashboard.Contracts.PublicUser;

/// <summary>
/// Публичная информация о пользователе.
/// </summary>
public class PublicUserDto : BaseDto
{
    /// <summary>
    /// Логин пользователя.
    /// </summary>
    public string UserLogin { get; set; }
    /// <summary>
    /// Дата регистрации.
    /// </summary>
    public string UserDateCreate { get; set; }
}