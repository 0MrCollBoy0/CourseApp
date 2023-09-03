using Microsoft.AspNetCore.Mvc;

namespace ElectronicAdsBoard.Hosts.Api.Controllers;
/// <summary>
/// Контроллер для работы с фотографиями объявлений.
/// </summary>
public class ImageController: ControllerBase
{
    /// <summary>
    /// Возвращает список фотографий по индентификатору.
    /// </summary>
    /// <param name="id">Идентификатор</param>
    /// <returns>Возвращает список фотографий <see cref="ImageDto"/></returns>
    public byte[] GetById(Guid id)
    {
        return null;
    }
}