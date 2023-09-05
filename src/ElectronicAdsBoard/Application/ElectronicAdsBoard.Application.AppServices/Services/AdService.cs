using ElectronicAdsBoard.Application.AppServices.Interfaces;
using ElectronicAdsBoard.Contracts;

namespace ElectronicAdsBoard.Application.AppServices.Services;

public class AdService:IAdService
{
    public IAsyncEnumerable<AdDto> GetAllAsync(int pageSize, int pageIndex)
    {
        return null;
    }

    public AdDto GetByIdAsync(Guid id)
    {
        return null;
    }

    public Task CreateAsync(AdDto dto)
    {
        return null;
    }

    public Task UpdateAsync(AdDto dto)
    {
        return null;
    }

    public Task DeleteAsync(Guid id)
    {
        return null;
    }
}