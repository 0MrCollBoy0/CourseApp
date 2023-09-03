using ElectronicAdsBoard.Domain.Base;

namespace ElectronicAdsBoard.Domain.Users;
/// <summary>
/// Сущность фотографии пользователя.
/// </summary>
public class UserImage:BaseEntity
{
    /// <summary>
    /// Фотография пользователя.
    /// </summary>
    public byte[] Image { get; set; }
}