using ElectronicAdsBoard.Application.AppServices.Interfaces;
using ElectronicAdsBoard.Contracts;
using ElectronicAdsBoard.Contracts.Ad;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ElectronicAdsBoard.Hosts.Api.Controllers.Ads;
/// <summary>
/// Контроллер для работы с объявлениями.
/// </summary>
[ApiController]
[Route("controller")]
public class AdController:ControllerBase
{

    private readonly IAdService _adService;

    public AdController(IAdService adService)
    {
        _adService = adService;
    }
    /// <summary>
    /// Возвращает объявления постранично.
    /// </summary>
    /// <param name="cancellationToken">Отмена</param>
    /// <param name="pageSize">Количество объявлений на каждой странице</param>
    /// <param name="pageIndex">Номер страницы</param>
    /// <returns>Список моделей объявления<see cref="AdDto"/></returns>
    [HttpGet("get-all")]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken, int pageSize = 10, int pageIndex = 0)
    {
        await _adService.GetAllAsync(pageSize, pageIndex, cancellationToken);
        return Ok();
    }

    /// <summary>
    /// Возвращает объявление по идентифекатору
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <param name="cancellationToken">Отмена</param>
    /// <returns>Модель объявления<see cref="AdDto"/> </returns>
    [HttpGet("get-by-id")]
    public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
       var result = await _adService.GetByIdAsync(id, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Создаёт новую модель объявления.
    /// </summary>
    /// <param name="dto">модель для создания</param>
    /// <param name="cancellationToken">Отмена</param>
    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreateAdDto dto, CancellationToken cancellationToken)
    {
        var modelAd = await _adService.CreateAsync(dto, cancellationToken);
        return Created(nameof(CreateAsync), modelAd);
    }

    /// <summary>
    /// Редактирует объявление.
    /// </summary>
    /// <param name="dto">Модель для изменения</param>
    /// <param name="cancellationToken">Отмена</param>
    [HttpPut]
    public async Task<IActionResult> UpdateAsync(AdDto dto, CancellationToken cancellationToken)
    {
        await _adService.UpdateAsync(dto, cancellationToken);
        return Ok();
    }

    /// <summary>
    /// Удаляет объявления по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор объявления</param>
    /// <param name="cancellationToken">Отмена</param>
    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        await _adService.DeleteAsync(id, cancellationToken);
        return Ok();
    }
}