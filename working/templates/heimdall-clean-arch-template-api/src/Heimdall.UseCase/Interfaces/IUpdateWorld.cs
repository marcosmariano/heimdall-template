using Heimdall.Domain;

namespace Heimdall.UseCase.Interfaces
{
    public interface IUpdateWorld
    {
        Task<World> UpdateWorldAsync(IUpdateWorld world);
    }
}