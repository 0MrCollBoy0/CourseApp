using ElectronicAdsBoard.Domain.Base;

namespace ElectronicAdsBoard.Domain.Users;
/// <summary>
/// Пользователь.
/// </summary>
public class User:BaseEntity
{
    /// <summary>
    /// Имя пользователя.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Фамилия пользователя.
    /// </summary>
    public string Surname { get; set; }
    /// <summary>
    /// Логин.
    /// </summary>
    public string Login { get; set; }
    /// <summary>
    /// Пароль.
    /// </summary>
    public string Pasword { get; set; }
}