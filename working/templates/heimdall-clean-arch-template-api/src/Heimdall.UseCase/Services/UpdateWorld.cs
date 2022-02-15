using Heimdall.Domain;
using Heimdall.Infrastructure.Repository.Interfaces;
using Heimdall.UseCase.Interfaces;
using Microsoft.Extensions.Logging;

namespace Heimdall.UseCase.Services
{
    public class UpdateWorld : IUpdateWorld
    {
        IWorldService _worldService;
        ILogger<UpdateWorld> _logger;

        public UpdateWorld(IWorldService worldService, ILogger<UpdateWorld> logger)
        {
            _worldService = worldService ?? throw new ArgumentNullException(nameof(worldService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<World> UpdateWorldAsync(World world)
        {
            using (_logger.BeginScope("UpdateWorldAsync - Update world registry"))
            {
                var updatedWorld = await _worldService.UpdateAsync(world);
                return updatedWorld;
            }
        }
    }
}