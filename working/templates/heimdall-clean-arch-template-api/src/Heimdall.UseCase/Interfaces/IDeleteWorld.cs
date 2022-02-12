namespace Heimdall.UseCase.Interfaces
{
    public interface IDeleteWorld
    {
        Task DeleteWorldAsync(IGetWorlds world);
    }
}