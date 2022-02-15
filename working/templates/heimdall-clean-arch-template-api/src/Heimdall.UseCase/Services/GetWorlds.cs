using Heimdall.Domain;
using Heimdall.Infrastructure.Repository.Interfaces;
using Heimdall.UseCase.Interfaces;
using Microsoft.Extensions.Logging;

namespace Heimdall.UseCase.Services
{
    public class GetWorlds : IGetWorlds
    {
        IWorldService _worldService;
        ILogger<GetWorlds> _logger;
        public GetWorlds(IWorldService worldService, ILogger<GetWorlds> logger)
        {
            _worldService = worldService ?? throw new ArgumentNullException(nameof(worldService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<List<World>> GetWorldsAsync()
        {
            using (_logger.BeginScope("GetWorldsAsync - Get all worlds"))
            {
                return await _worldService.GetAllAsync();
            }
        }
    }
}