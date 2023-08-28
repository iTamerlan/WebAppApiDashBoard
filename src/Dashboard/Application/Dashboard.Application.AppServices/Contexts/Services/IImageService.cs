using Dashboard.Contracts.Attachment;

namespace Dashboard.Application.AppServices.Contexts.Services;

/// <summary>
/// Репозиторий для работы с изображениями.
/// </summary>
public interface IImageService
{
    /// <summary>
    /// Возвращает изображение по идентификатору.
    /// </summary>
    /// <param name="id">Идентификатор изображения.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Модель объявления <see cref="ImageDto"/></returns>
    Task<ImageDto> GetByIdAsync(Guid id, CancellationToken cancellationToken);
}