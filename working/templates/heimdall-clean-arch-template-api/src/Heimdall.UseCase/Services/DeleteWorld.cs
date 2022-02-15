using Heimdall.Domain;
using Heimdall.Infrastructure.Repository.Interfaces;
using Heimdall.UseCase.Interfaces;
using Microsoft.Extensions.Logging;

namespace Heimdall.UseCase.Services
{
    public class DeleteWorld : IDeleteWorld
    {
        IWorldService _worldService;
        ILogger<DeleteWorld> _logger;
        public DeleteWorld(IWorldService worldService, ILogger<DeleteWorld> logger)
        {
            _worldService = worldService ?? throw new ArgumentNullException(nameof(worldService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task DeleteWorldAsync(World world)
        {
            using (_logger.BeginScope("DeleteWorldAsync - Delete world"))
            {
                await _worldService.DeleteAsync(world);
            }
        }
    }
}