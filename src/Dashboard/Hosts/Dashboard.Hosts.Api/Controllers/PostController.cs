﻿using System.Net;
using Dashboard.Application.AppServices.Contexts.Post.Services;
using Dashboard.Contracts.Post;
using Microsoft.AspNetCore.Mvc;

namespace Dashboard.Hosts.Api.Controllers;

/// <summary>
/// Контроллер для работы с объявлениями.
/// </summary>
[ApiController]
[Route("post")]
public class PostController : ControllerBase
{
    private readonly IPostService _postService;

    /// <summary>
    /// Инициализирует экзепляр <see cref="PostController"/>
    /// </summary>
    /// <param name="postService">Сервис работы с объявлениями.</param>
    public PostController(IPostService postService)
    {
        _postService = postService;
    }

    /// <summary>
    /// Возвращает объявление по идентификатору.
    /// </summary>
    /// <remarks>
    /// Пример:
    /// curl -XGET http://host:port/post/get-by-id
    /// </remarks>
    /// <param name="id">Идентификатор объявления.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель объявления <see cref="PostDto"/></returns>
    [HttpGet("get-by-id")]
    [ProducesResponseType(typeof(PostDto), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    [ProducesResponseType((int)HttpStatusCode.InternalServerError)]
    public async Task<IActionResult> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        var result = await _postService.GetByIdAsync(id, cancellationToken);
        return Ok(result);
    }

    /// <summary>
    /// Возвращает постраничные объявления.
    /// </summary>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <param name="pageSize">Размер страницы.</param>
    /// <param name="pageIndex">Номер страницы.</param>
    /// <returns>Коллекция объявлений <see cref="PostDto"/></returns>
    [HttpGet("get-all-paged")]
    public async Task<IActionResult> GetAllAsync(CancellationToken cancellationToken, int pageSize = 10, int pageIndex = 0)
    {
        return Ok();
    }

    /// <summary>
    /// Создает объявление.
    /// </summary>
    /// <param name="dto">Модель для создания объявления</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Идентификатор созданной сущности</returns>
    [HttpPost]
    public async Task<IActionResult> CreateAsync(CreatePostDto dto, CancellationToken cancellationToken)
    {
        var modelId = await _postService.CreateAsync(dto, cancellationToken);
        /*if (string.IsNullOrEmpty(dto.Title))
        {
            ModelState.AddModelError(nameof(dto.Title, "Поле Title должно содержать значение");
        }
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }*/
        return Created(nameof(CreateAsync), modelId);
    }
    
    /// <summary>
    /// Редактирует объявление.
    /// </summary>
    /// <param name="cancellationToken">Отмена операции.</param>
    [HttpPut]
    public async Task<IActionResult> UpdateAsync(PostDto dto, CancellationToken cancellationToken)
    {
        return Ok();
    }
    
    /// <summary>
    /// Удаляем объявление по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор объявления.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    [HttpDelete]
    public async Task<IActionResult> DeleteAsync(Guid id, CancellationToken cancellationToken)
    {
        return Ok();
    }
}