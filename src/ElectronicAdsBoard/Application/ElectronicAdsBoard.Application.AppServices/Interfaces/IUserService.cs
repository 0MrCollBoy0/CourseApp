using ElectronicAdsBoard.Contracts.User;

namespace ElectronicAdsBoard.Application.AppServices.Interfaces;

public interface IUserService
{
    Task CreateAsync(UserDto dto);
    Task UpdateAsync(UserDto dto);
    Task DeleteAsync(Guid id);

}