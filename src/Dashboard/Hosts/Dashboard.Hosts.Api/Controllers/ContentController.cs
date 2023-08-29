using System.Net;
using Dashboard.Application.AppServices.Contexts.Content.Services;
using Dashboard.Application.AppServices.Contexts.Post.Services;
using Dashboard.Contracts.Content;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Hosts.Api.Controllers;

/// <summary>
/// Контроллер для работы с блоками контента.
/// </summary>
[ApiController]
[Route("content")]
public class ContentController : ControllerBase
{
    private readonly IContentService _contentService;

    /// <summary>
    /// Инициализирует экзепляр <see cref="contentController"/>
    /// </summary>
    /// <param name="contentService">Сервис работы с блоками контента.</param>
    public ContentController(IContentService contentService)
    {
        _contentService = contentService;
    }

    /// <summary>
    /// Возвращает блок контента по идентификатору.
    /// </summary>
    /// <remarks>
    /// Пример:
    /// curl -XGET http://host:port/content/get-by-id
    /// </remarks>
    /// <param name="id">Идентификатор блока контента.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель блока контента <see cref="ContentDto"/></returns>
    [HttpGet("get-by-id")]
    [ProducesResponseType(typeof(ContentDto), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
    public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var result = await _contentService.GetByIdAsync(id, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Возвращает постраничные блоки контента.
    /// </summary>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <param name="pageSize">Размер страницы.</param>
    /// <param name="pageIndex">Номер страницы.</param>
    /// <returns>Коллекция блоков контента <see cref="ContentDto"/></returns>
    [HttpGet("get-all-paged")]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken, int pageSize = 10, int pageIndex = 0)
    {
        return Ok();
    }

    /// <summary>
    /// Создает блок контента.
    /// </summary>
    /// <param name="dto">Модель для создания блока контента</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Идентификатор созданной сущности</returns>
    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreateContentDto dto, CancellationToken cancellationToken)
    {
        var modelId = await _contentService.CreateAsync(dto, cancellationToken);
        return Created(nameof(CreateAsync), modelId);
    }
    
    /// <summary>
    /// Редактирует блока контента.
    /// </summary>
    /// <param name="cancellationToken">Отмена операции.</param>
    [HttpPut]
    public async Task<IActionResult> UpdateAsync(ContentDto dto, CancellationToken cancellationToken)
    {
        return Ok();
    }
    
    /// <summary>
    /// Удаляем блок контента по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор блока контента.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        return Ok();
    }
}