using ElectronicAdsBoard.Contracts.Base;

namespace ElectronicAdsBoard.Contracts.Image;

public class ImageDto:BaseDto
{
    /// <summary>
    /// Фотографии товара.
    /// </summary>
    public byte[][] Images { get; set; }
}