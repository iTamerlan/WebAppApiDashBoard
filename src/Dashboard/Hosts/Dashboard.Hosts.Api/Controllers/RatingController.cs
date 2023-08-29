using System.Net;
using Dashboard.Application.AppServices.Contexts.Post.Services;
using Dashboard.Application.AppServices.Contexts.Services;
using Dashboard.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Hosts.Api.Controllers;

/// <summary>
/// Контроллер для работы с рейтингом.
/// </summary>
[ApiController]
[Route("rating")]
public class RatingController : ControllerBase
{
    private readonly IRatingService _ratingService;

    /// <summary>
    /// Инициализирует экзепляр <see cref="RatingController"/>
    /// </summary>
    /// <param name="ratingService">Сервис работы с рейтингом.</param>
    public RatingController(IRatingService ratingService)
    {
        _ratingService = ratingService;
    }

    /// <summary>
    /// Возвращает рейтинг по идентификатору.
    /// </summary>
    /// <remarks>
    /// Пример:
    /// curl -XGET http://host:port/rating/get-by-id
    /// </remarks>
    /// <param name="id">Идентификатор рейтинга.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель рейтинга <see cref="RatingDto"/></returns>
    [HttpGet("get-by-id")]
    [ProducesResponseType(typeof(RatingDto), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
    public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var result = await _ratingService.GetByIdAsync(id, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Возвращает постраничные рейтинги.
    /// </summary>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <param name="pageSize">Размер страницы.</param>
    /// <param name="pageIndex">Номер страницы.</param>
    /// <returns>Коллекция рейтингов <see cref="RatingDto"/></returns>
    [HttpGet("get-all-paged")]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken, int pageSize = 10, int pageIndex = 0)
    {
        return Ok();
    }
    
    /// <summary>
    /// Создает рейтинг.
    /// </summary>
    /// <param name="cancellationToken">Отмена операции.</param>
    [HttpPost]
    public async Task<IActionResult> CreateAsync(RatingDto dto, CancellationToken cancellationToken)
    {
        return Created(string.Empty, null);
    }
    
    /// <summary>
    /// Редактирует рейтинг.
    /// </summary>
    /// <param name="cancellationToken">Отмена операции.</param>
    [HttpPut]
    public async Task<IActionResult> UpdateAsync(RatingDto dto, CancellationToken cancellationToken)
    {
        return Ok();
    }
    
    /// <summary>
    /// Удаляем рейтинг по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор рейтинга.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        return Ok();
    }
}