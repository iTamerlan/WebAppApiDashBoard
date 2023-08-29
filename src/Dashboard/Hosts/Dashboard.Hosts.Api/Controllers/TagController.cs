using System.Net;
using Dashboard.Application.AppServices.Contexts.Post.Services;
using Dashboard.Application.AppServices.Contexts.Tag.Services;
using Dashboard.Contracts.Tag;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Hosts.Api.Controllers;

/// <summary>
/// Контроллер для работы с тегами.
/// </summary>
[ApiController]
[Route("tag")]
public class TagController : ControllerBase
{
    private readonly ITagService _tagService;

    /// <summary>
    /// Инициализирует экзепляр <see cref="TagController"/>
    /// </summary>
    /// <param name="tagService">Сервис работы с тегами.</param>
    public TagController(ITagService tagService)
    {
        _tagService = tagService;
    }

    /// <summary>
    /// Возвращает тег по идентификатору.
    /// </summary>
    /// <remarks>
    /// Пример:
    /// curl -XGET http://host:port/tag/get-by-id
    /// </remarks>
    /// <param name="id">Идентификатор тега.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель тега <see cref="TagDto"/></returns>
    [HttpGet("get-by-id")]
    [ProducesResponseType(typeof(TagDto), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
    public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var result = await _tagService.GetByIdAsync(id, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Возвращает постраничные теги.
    /// </summary>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <param name="pageSize">Размер страницы.</param>
    /// <param name="pageIndex">Номер страницы.</param>
    /// <returns>Коллекция тегов <see cref="TagDto"/></returns>
    [HttpGet("get-all-paged")]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken, int pageSize = 10, int pageIndex = 0)
    {
        return Ok();
    }

    /// <summary>
    /// Создает тег.
    /// </summary>
    /// <param name="dto">Модель для создания тега</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Идентификатор созданной сущности</returns>
    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreateTagDto dto, CancellationToken cancellationToken)
    {
        var modelId = await _tagService.CreateAsync(dto, cancellationToken);
        return Created(nameof(CreateAsync), modelId);
    }
    
    /// <summary>
    /// Редактирует тег.
    /// </summary>
    /// <param name="cancellationToken">Отмена операции.</param>
    [HttpPut]
    public async Task<IActionResult> UpdateAsync(TagDto dto, CancellationToken cancellationToken)
    {
        return Ok();
    }
    
    /// <summary>
    /// Удаляем тег по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор тега.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        return Ok();
    }
}