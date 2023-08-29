using Dashboard.Application.AppServices.Contexts.Image.Repositories;
using Dashboard.Contracts.Image;
using Dashboard.Domain.Posts;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Image.Repositories;

public class ImageRepository : IImageRepository
{
    private readonly List<Domain.Images.Image> _images = new();
    public Task<ImageDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return Task.Run(() => new ImageDto
        {
            Id = Guid.NewGuid(),
            DescriptionImage = "Тестовое изображение",
            DateUpload = "21.12.2012",
            UrlImage = "https://i.pinimg.com/originals/fc/c4/3a/fcc43ac7e465ddd9236c38032b7f53e4.jpg",
            Private = "Public",
            CategoryName = "Android"
        }, cancellationToken);
    }

    /// <inheritdoc />
    public Task<Guid> CreateAsync(Domain.Images.Image model, CancellationToken cancellationToken)
    {
        model.Id = Guid.NewGuid();
        _images.Add(model);
        return Task.Run(() => model.Id);
    }
}