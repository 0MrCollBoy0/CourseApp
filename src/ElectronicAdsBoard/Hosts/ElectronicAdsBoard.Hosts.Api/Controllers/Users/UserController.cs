using ElectronicAdsBoard.Application.AppServices.Interfaces;
using ElectronicAdsBoard.Contracts.User;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicAdsBoard.Hosts.Api.Controllers.Users;

public class UserController
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }
    [HttpPost]
    public async Task<IActionResult> CreateAsync(UserDto dto, CancellationToken cancellationToken)
    {
        await _userService.CreateAsync(dto);
        return null;
    }

    public async Task<IActionResult> UpdateAsync(UserDto dto, CancellationToken cancellationToken)
    {
        await _userService.UpdateAsync(dto);
        return null;
    }

    public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        await _userService.DeleteAsync(id);
        return null;
    }
}