using Dashboard.Application.AppServices.Contexts.Post.Repositories;
using Dashboard.Contracts.Attachment;

namespace Dashboard.Infrastructure.DataAccess.Contexts.Post.Repositories;

public class ImageRepository : IImageRepository
{
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
}