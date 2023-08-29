using System.Net;
using Dashboard.Application.AppServices.Contexts.Post.Services;
using Dashboard.Application.AppServices.Contexts.Services;
using Dashboard.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Hosts.Api.Controllers;

/// <summary>
/// Контроллер для работы с расширенными объявлениями.
/// </summary>
[ApiController]
[Route("postext")]
public class PostExtController : ControllerBase
{
    private readonly IPostExtService _postExtService;

    /// <summary>
    /// Инициализирует экзепляр <see cref="PostExtController"/>
    /// </summary>
    /// <param name="postExtService">Сервис работы с расширенными объявлениями.</param>
    public PostExtController(IPostExtService postExtService)
    {
        _postExtService = postExtService;
    }

    /// <summary>
    /// Возвращает расширенное объявление по идентификатору.
    /// </summary>
    /// <remarks>
    /// Пример:
    /// curl -XGET http://host:port/postext/get-by-id
    /// </remarks>
    /// <param name="id">Идентификатор расширенного объявления.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель расширенного объявления <see cref="PostExtDto"/></returns>
    [HttpGet("get-by-id")]
    [ProducesResponseType(typeof(PostExtDto), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
    public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var result = await _postExtService.GetByIdAsync(id, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Возвращает постраничные расширенные объявления.
    /// </summary>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <param name="pageSize">Размер страницы.</param>
    /// <param name="pageIndex">Номер страницы.</param>
    /// <returns>Коллекция расширенных объявлений <see cref="PostExtDto"/></returns>
    [HttpGet("get-all-paged")]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken, int pageSize = 10, int pageIndex = 0)
    {
        return Ok();
    }
    
    /// <summary>
    /// Создает расширенное объявление.
    /// </summary>
    /// <param name="cancellationToken">Отмена операции.</param>
    [HttpPost]
    public async Task<IActionResult> CreateAsync(PostExtDto dto, CancellationToken cancellationToken)
    {
        return Created(string.Empty, null);
    }
    
    /// <summary>
    /// Редактирует расширенное объявление.
    /// </summary>
    /// <param name="cancellationToken">Отмена операции.</param>
    [HttpPut]
    public async Task<IActionResult> UpdateAsync(PostExtDto dto, CancellationToken cancellationToken)
    {
        return Ok();
    }
    
    /// <summary>
    /// Удаляем расширенное объявление по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор расширенного объявления.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        return Ok();
    }
}