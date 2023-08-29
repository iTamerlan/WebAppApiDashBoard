using Dashboard.Application.AppServices.Contexts.Image.Repositories;
using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Contracts.Image;
using Dashboard.Contracts.Post;

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

    /// <inheritdoc />
    public Task<Guid> CreateAsync(CreateImageDto model, CancellationToken cancellationToken)
    {
        var image = new Domain.Images.Image()
        {
            DescriptionImage = model.DescriptionImage,
            DateUpload = model.DateUpload,
            UrlImage = model.UrlImage,
            Private = model.Private,
            CategoryId = model.CategoryId,
        };

        return _imageRepository.CreateAsync(image, cancellationToken);
    }
}