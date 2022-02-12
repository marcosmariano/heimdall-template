using Heimdall.Domain;

namespace Heimdall.UseCase.Interfaces
{
    public interface IGetWorlds
    {
        Task<List<World>> GetWorldsAsync();
    }
}