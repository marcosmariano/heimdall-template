using Heimdall.Domain;
using Heimdall.Infrastructure.Repository.Interfaces;
using Heimdall.UseCase.Interfaces;
using Microsoft.Extensions.Logging;

namespace Heimdall.UseCase.Services
{
    public class GetWorldById : IGetWorldById
    {
        IWorldService _worldService;
        ILogger<GetWorldById> _logger;
        public GetWorldById(IWorldService worldService, ILogger<GetWorldById> logger)
        {
            _worldService = worldService ?? throw new ArgumentNullException(nameof(worldService));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }
        public async Task<World> GetWorldByIdAsync(Guid id)
        {
            using (_logger.BeginScope("GerWorldByIdAsync - Get world by Id"))
            {
                return await _worldService.GetByIdAsync(id);
            }
        }
    }
}