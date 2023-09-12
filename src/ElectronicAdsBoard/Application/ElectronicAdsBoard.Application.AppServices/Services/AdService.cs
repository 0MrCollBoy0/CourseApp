using ElectronicAdsBoard.Application.AppServices.Interfaces;
using ElectronicAdsBoard.Contracts;
using ElectronicAdsBoard.Contracts.Ad;
using ElectronicAdsBoard.Domain.Ads;

namespace ElectronicAdsBoard.Application.AppServices.Services;

public class AdService:IAdService
{
    private readonly IAdRepository _adRepository;

    public AdService(IAdRepository adRepository)
    {
        _adRepository = adRepository;
    }
    public async Task<IEnumerable<AdDto>> GetAllAsync(int pageSize, int pageIndex, CancellationToken cancellationToken)
    {
        return null;
    }

    public Task<AdDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return _adRepository.GetByIdAsync(id, cancellationToken);
    }
    

    public Task<Guid> CreateAsync(CreateAdDto dto, CancellationToken cancellationToken)
    {
        var ad = new Ad
        {
            Name = dto.Name,
            Price = dto.Price,
            Address = dto.Address,
            Tags = dto.Tags,
            Description = dto.Description,
            CategoryId = dto.CategoryId
        };
        return _adRepository.CreateAsync(ad, cancellationToken);
    }

    public Task UpdateAsync(AdDto dto, CancellationToken cancellationToken)
    {
        return null;
    }

    public Task DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        return null;
    }
}