using Heimdall.Domain;

namespace Heimdall.UseCase.Interfaces
{
    public interface IDeleteWorld
    {
        Task DeleteWorldAsync(World world);
    }
}