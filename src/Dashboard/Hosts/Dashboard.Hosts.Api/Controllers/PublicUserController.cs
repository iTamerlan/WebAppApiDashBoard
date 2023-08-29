using System.Net;
using Dashboard.Application.AppServices.Contexts.Post.Services;
using Dashboard.Application.AppServices.Contexts.PublicUser.Services;
using Dashboard.Contracts.Attachment;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Hosts.Api.Controllers;

/// <summary>
/// Контроллер для отображения публичной информации о пользователе.
/// </summary>
[ApiController]
[Route("user")]
public class PublicUserController : ControllerBase
{
    private readonly IPublicUserService _publicUserService;

    /// <summary>
    /// Инициализирует экзепляр <see cref="PublicUserController"/>
    /// </summary>
    /// <param name="publicUserService">Сервис работы с публичной информацией о пользователе.</param>
    public PublicUserController(IPublicUserService publicUserService)
    {
        _publicUserService = publicUserService;
    }

    /// <summary>
    /// Возвращает публичную часть пользователя по идентификатору.
    /// </summary>
    /// <remarks>
    /// Пример:
    /// curl -XGET http://host:port/user/get-by-id
    /// </remarks>
    /// <param name="id">Идентификатор пользователя.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель публичной информации о пользователе <see cref="PublicUserDto"/></returns>
    [HttpGet("get-by-id")]
    [ProducesResponseType(typeof(PublicUserDto), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
    public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var result = await _publicUserService.GetByIdAsync(id, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Возвращает постраничный список пользователей.
    /// </summary>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <param name="pageSize">Размер страницы.</param>
    /// <param name="pageIndex">Номер страницы.</param>
    /// <returns>Коллекция пользователей <see cref="PublicUserDto"/></returns>
    [HttpGet("get-all-paged")]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken, int pageSize = 10, int pageIndex = 0)
    {
        return Ok();
    }
}