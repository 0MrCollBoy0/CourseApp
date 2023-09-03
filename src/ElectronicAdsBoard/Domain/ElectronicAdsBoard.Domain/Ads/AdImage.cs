using ElectronicAdsBoard.Domain.Base;

namespace ElectronicAdsBoard.Domain.Ads;
/// <summary>
/// Сущность фотографий товара.
/// </summary>
public class AdImage:BaseEntity
{
    /// <summary>
    /// Фотографии товара.
    /// </summary>
    public byte[] Images { get; set; }
}