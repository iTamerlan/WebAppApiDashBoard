using Dashboard.Application.AppServices.Contexts.Image.Repositories;
using Dashboard.Contracts.Attachment;

namespace Dashboard.Application.AppServices.Contexts.Image.Services;

/// <inheritdoc />
public class ImageService : IImageService
{
    private readonly IImageRepository _imageRepository;

    /// <summary>
    /// Инициализирует экзепляр <see cref="ImageService"/>
    /// </summary>
    /// <param name="imageRepository">Репозиторий для работы с изображениями.</param>
    public ImageService(IImageRepository imageRepository)
    {
        _imageRepository = imageRepository;
    }

    /// <inheritdoc />
    public Task<ImageDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return _imageRepository.GetByIdAsync(id, cancellationToken);
    }
}