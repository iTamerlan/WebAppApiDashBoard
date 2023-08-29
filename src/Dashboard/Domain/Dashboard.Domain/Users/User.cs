using Dashboard.Domain.Base;

namespace Dashboard.Domain.Users;

/// <summary>
/// Сущность пользователя.
/// </summary>
public class User : BaseEntity
{
    /// <summary>
    /// Логин.
    /// </summary>
    public string Login { get; set; }
    /// <summary>
    /// Пароль.
    /// </summary>
    public string Password { get; set; }
    /// <summary>
    /// Регистрационный Email.
    /// </summary>
    public string EmailReg { get; set; }
    /// <summary>
    /// Email для связи.
    /// </summary>
    public string EmailCommunication { get; set; }
    /// <summary>
    /// Дата регистрации пользователя.
    /// </summary>
    public string DataCreate { get; set; }
    /// <summary>
    /// Дата установки последнего пароля.
    /// </summary>
    public string DateSetPass { get; set; }
    /// <summary>
    /// Телефон.
    /// </summary>
    public string Phone { get; set; }

}