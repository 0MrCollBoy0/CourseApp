using ElectronicAdsBoard.Domain.Base;

namespace ElectronicAdsBoard.Domain.Ads;

public class Image:BaseEntity
{
    /// <summary>
    /// Фотографии товара.
    /// </summary>
    public byte[] Images { get; set; }
}