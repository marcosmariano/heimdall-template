using Heimdall.Domain;

namespace Heimdall.UseCase.Interfaces
{
    public interface ICreateWorld
    {
        Task<World> CreateWorldAsync(World world);
    }
}