namespace ElectronicAdsBoard.Domain.Ads;
/// <summary>
/// сущность объявлений
/// </summary>
public class Ad
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
    /// Описание товара.
    /// </summary>
    public string Description { get; set; }
    /// <summary>
    /// Идентификатор категории товара.
    /// </summary>
    public Guid CategoryId { get; set; }
}