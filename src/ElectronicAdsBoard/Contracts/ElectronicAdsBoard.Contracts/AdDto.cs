using System.Net.Mail;
using ElectronicAdsBoard.Contracts.Base;
using ElectronicAdsBoard.Contracts.Image;

namespace ElectronicAdsBoard.Contracts;
/// <summary>
/// Объявление.
/// </summary>
public class AdDto:BaseDto
{
    /// <summary>
    /// Имя товара.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Цена товара.
    /// </summary>
    public decimal Price { get; set; }
    /// <summary>
    /// Адрес, где можно забрать товар.
    /// </summary>
    public string Address { get; set; }
    /// <summary>
    /// Теги к товару.
    /// </summary>
    public string[] Tags { get; set; }
    /// <summary>
    /// Изображения.
    /// </summary>
    public IReadOnlyCollection<ImageDto> Images { get; set; }
    /// <summary>
    /// Описание товара.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Название категории товара.
    /// </summary>
    public string Category { get; set; }
}