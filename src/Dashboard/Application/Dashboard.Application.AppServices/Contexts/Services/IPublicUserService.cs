using Dashboard.Contracts.Attachment;

namespace Dashboard.Application.AppServices.Contexts.Services;

/// <summary>
/// Репозиторий для работы с публичной частью пользователя.
/// </summary>
public interface IPublicUserService
{
    /// <summary>
    /// Возвращает публичную часть пользователя по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор пользователя.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель объявления <see cref="PublicUserDto"/></returns>
    Task<PublicUserDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}