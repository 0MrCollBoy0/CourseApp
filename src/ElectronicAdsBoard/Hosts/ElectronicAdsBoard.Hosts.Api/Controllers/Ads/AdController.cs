﻿using ElectronicAdsBoard.Application.AppServices.Interfaces;
using ElectronicAdsBoard.Contracts;
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
        _adService.GetAllAsync(pageSize, pageIndex);
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
        _adService.GetByIdAsync(id);
        return Ok();
    }

    /// <summary>
    /// Создаёт новую модель объявления.
    /// </summary>
    /// <param name="dto">модель для создания</param>
    /// <param name="cancellationToken">Отмена</param>
    [HttpPost]
    public async Task<IActionResult> CreateAsync(AdDto dto, CancellationToken cancellationToken)
    {
        _adService.CreateAsync(dto);
        return Created(string.Empty, null);
    }

    /// <summary>
    /// Редактирует объявление.
    /// </summary>
    /// <param name="dto">Модель для изменения</param>
    /// <param name="cancellationToken">Отмена</param>
    [HttpPut]
    public async Task<IActionResult> UpdateAsync(AdDto dto, CancellationToken cancellationToken)
    {
        _adService.UpdateAsync(dto);
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
        _adService.DeleteAsync(id);
        return Ok();
    }
}