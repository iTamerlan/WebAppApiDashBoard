using Dashboard.Application.AppServices.Contexts.Repositories;
using Dashboard.Contracts.Attachment;

namespace Dashboard.Application.AppServices.Contexts.Services;

/// <inheritdoc />
public class PublicUserService : IPublicUserService
{
    private readonly IPublicUserRepository _publicUserRepository;

    /// <summary>
    /// Инициализирует экзепляр <see cref="PublicUserService"/>
    /// </summary>
    /// <param name="publicUserRepository">Репозиторий для работы с объявлениями.</param>
    public PublicUserService(IPublicUserRepository publicUserRepository)
    {
        _publicUserRepository = publicUserRepository;
    }

    /// <inheritdoc />
    public Task<PublicUserDto> GetByIdAsync(Guid id, CancellationToken cancellationToken)
    {
        return _publicUserRepository.GetByIdAsync(id, cancellationToken);
    }
}