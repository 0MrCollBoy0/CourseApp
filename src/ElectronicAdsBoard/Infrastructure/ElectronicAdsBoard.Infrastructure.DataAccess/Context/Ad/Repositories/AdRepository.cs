using ElectronicAdsBoard.Application.AppServices.Interfaces;
using ElectronicAdsBoard.Contracts;

namespace ElectronicAdsBoard.Infrastructure.Access.Context.Ad.Repositories;

public class AdRepository:IAdRepository
{
    private readonly List<Domain.Ads.Ad> _ad = new();
    public Task<AdDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return Task.Run(() => new AdDto
        {
            Id = Guid.NewGuid(),
            Name = "Тестовое объявление",
            Price = 555,
            Address = "Sevastopol",
            Tags = new []{"тест1","тест2"},
            Description = "Тестовое описание",
            Category = "Тестовая категория"
        }, cancellationToken);
    }

    public Task<Guid> CreateAsync(Domain.Ads.Ad ad, CancellationToken cancellationToken)
    {
        ad.Id = Guid.NewGuid();
        _ad.Add(ad);
        return Task.Run(() => ad.Id);
    }
}