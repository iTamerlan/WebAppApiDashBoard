using Dashboard.Contracts.Image;
using Dashboard.Contracts.Post;

namespace Dashboard.Application.AppServices.Contexts.Image.Services;

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

    /// <summary>
    /// Создает изображение по модели.
    /// </summary>
    /// <param name="model">Модель изображения.</param>
    /// <param name="cancellationToken">Отмена операции.</param>
    /// <returns>Идентификатор созданной сущности</returns>
    Task<Guid> CreateAsync(CreateImageDto model, CancellationToken cancellationToken);
}