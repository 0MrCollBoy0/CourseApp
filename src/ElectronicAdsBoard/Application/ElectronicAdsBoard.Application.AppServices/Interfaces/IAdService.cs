using ElectronicAdsBoard.Contracts;

namespace ElectronicAdsBoard.Application.AppServices.Interfaces;

public interface IAdService
{
    IAsyncEnumerable<AdDto> GetAllAsync(int pageSize, int pageIndex);
    AdDto GetByIdAsync(Guid id);
    Task CreateAsync(AdDto dto);
    Task UpdateAsync(AdDto dto);
    Task DeleteAsync(Guid id);
}