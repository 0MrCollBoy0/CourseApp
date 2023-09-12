using ElectronicAdsBoard.Contracts;
using ElectronicAdsBoard.Domain.Ads;

namespace ElectronicAdsBoard.Application.AppServices.Interfaces;

public interface IAdRepository
{
    /// <summary>
    /// Возвращает объявление по идентификатору
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="cancellationToken">Отмена</param>
    /// <returns>Объявление <see cref="AdDto"/></returns>
    Task<AdDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    
    /// <summary>
    /// Создаёт объявление.
    /// </summary>
    /// <param name="ad">Объявление.</param>
    /// <param name="cancellationToken">Отмена.</param>
    /// <returns>Id созданного объявления</returns>
    Task<Guid> CreateAsync(Ad ad, CancellationToken cancellationToken);
}