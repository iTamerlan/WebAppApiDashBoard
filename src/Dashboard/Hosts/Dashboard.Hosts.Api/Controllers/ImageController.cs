using System.Net;
using Dashboard.Application.AppServices.Contexts.Image.Services;
using Dashboard.Application.AppServices.Contexts.Post.Services;
using Dashboard.Contracts.Image;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Hosts.Api.Controllers;

/// <summary>
/// Контроллер для работы с изображениями.
/// </summary>
[ApiController]
[Route("image")]
public class ImageController : ControllerBase
{
    private readonly IImageService _imageService;

    /// <summary>
    /// Инициализирует экзепляр <see cref="ImageController"/>
    /// </summary>
    /// <param name="imageService">Сервис работы с изображениями.</param>
    public ImageController(IImageService imageService)
    {
        _imageService = imageService;
    }

    /// <summary>
    /// Возвращает изображение по идентификатору.
    /// </summary>
    /// <remarks>
    /// Пример:
    /// curl -XGET http://host:port/image/get-by-id
    /// </remarks>
    /// <param name="id">Идентификатор изображения.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель объявления <see cref="ImageDto"/></returns>
    [HttpGet("get-by-id")]
    [ProducesResponseType(typeof(ImageDto), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
    public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var result = await _imageService.GetByIdAsync(id, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Возвращает постраничные изображения.
    /// </summary>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <param name="pageSize">Размер страницы.</param>
    /// <param name="pageIndex">Номер страницы.</param>
    /// <returns>Коллекция изображений <see cref="ImageDto"/></returns>
    [HttpGet("get-all-paged")]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken, int pageSize = 10, int pageIndex = 0)
    {
        return Ok();
    }

    /// <summary>
    /// **Загружает** изображение.
    /// </summary>
    /// <param name="dto">Модель для создания изображения</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Идентификатор созданной сущности</returns>
    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreateImageDto dto, CancellationToken cancellationToken)
    {
        var modelId = await _imageService.CreateAsync(dto, cancellationToken);
        return Created(nameof(CreateAsync), modelId);
    }
    
    /// <summary>
    /// Заменяет изображение (редактирование).
    /// </summary>
    /// <param name="cancellationToken">Отмена операции.</param>
    [HttpPut]
    public async Task<IActionResult> UpdateAsync(ImageDto dto, CancellationToken cancellationToken)
    {
        return Ok();
    }
    
    /// <summary>
    /// Удаляем изображение по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор изображения.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        return Ok();
    }
}