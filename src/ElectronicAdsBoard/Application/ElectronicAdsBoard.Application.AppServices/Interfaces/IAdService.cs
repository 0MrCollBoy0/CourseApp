using ElectronicAdsBoard.Contracts;

namespace ElectronicAdsBoard.Application.AppServices.Interfaces;

public interface IAdService
{
    Task<IEnumerable<AdDto>> GetAllAsync(int pageSize, int pageIndex);
    Task<AdDto> GetByIdAsync(Guid id);
    Task CreateAsync(AdDto dto);
    Task UpdateAsync(AdDto dto);
    Task DeleteAsync(Guid id);
}