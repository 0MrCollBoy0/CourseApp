using ElectronicAdsBoard.Contracts;
using ElectronicAdsBoard.Contracts.Ad;

namespace ElectronicAdsBoard.Application.AppServices.Interfaces;

public interface IAdService
{
    Task<IEnumerable<AdDto>> GetAllAsync(int pageSize, int pageIndex, CancellationToken cancellationToken);
    Task<AdDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);
    Task<Guid> CreateAsync(CreateAdDto dto, CancellationToken cancellationToken);
    Task UpdateAsync(AdDto dto, CancellationToken cancellationToken);
    Task DeleteAsync(Guid id, CancellationToken cancellationToken);
}