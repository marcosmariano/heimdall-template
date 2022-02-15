using Heimdall.Domain;
using Heimdall.Infrastructure.Repository.Interfaces;
using Heimdall.UseCase.Interfaces;
using Microsoft.Extensions.Logging;

namespace Heimdall.UseCase.Services
{
    public class CreateWorld : ICreateWorld
    {
        IWorldService _worldService;
        ILogger<CreateWorld> _logger;
        public CreateWorld(IWorldService worldService, ILogger<CreateWorld> logger)
        {
            _worldService = worldService ?? throw new ArgumentNullException(nameof(worldService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<World> CreateWorldAsync(World world)
        {
            using (_logger.BeginScope("CreateWorldAsync - Creating new world"))
            {
                var worldResult = await _worldService.InsertAsync(world);
                return worldResult;
            }
        }
    }
}