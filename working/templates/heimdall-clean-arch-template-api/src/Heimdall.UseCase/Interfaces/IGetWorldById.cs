using Heimdall.Domain;

namespace Heimdall.UseCase.Interfaces
{
    public interface IGetWorldById
    {
        Task<World> GetWorldByIdAsync(Guid id);
    }
}