using Arch.EntityFrameworkCore.UnitOfWork;
using Heimdall.Domain;
using Heimdall.Infrastructure.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.DynamicLinq;
using Microsoft.Extensions.Logging;

namespace Heimdall.Infrastructure.Repository.Services
{
    public sealed class WorldService : IBaseService<World, Guid>
    {
        private bool disposedValue;
        private readonly AppDbContext _context;
        private readonly ILogger<WorldService> _logger;

        public WorldService(AppDbContext context, ILogger<WorldService> logger)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task<World> InsertAsync(World entity)
        {
            if (disposedValue)
                throw new ObjectDisposedException(nameof(WorldService));

            await _context.Worlds.AddAsync(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<World> UpdateAsync(World entity)
        {
            if (disposedValue)
                throw new ObjectDisposedException(nameof(WorldService));

            _context.Worlds.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<World> GetByIdAsync(Guid id)
        {
            if (disposedValue)
                throw new ObjectDisposedException(nameof(WorldService));

            return await _context.Worlds
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id.Equals(id));

        }

        public Task DeleteAsync(World entity)
        {
            if (disposedValue)
                throw new ObjectDisposedException(nameof(WorldService));

            return Task.FromResult(_context.Worlds.Remove(entity));
        }

        public async Task<List<World>> GetAllAsync()
        {
            if (disposedValue)
                throw new ObjectDisposedException(nameof(WorldService));

            var query =   _context.Worlds
                                .AsNoTracking()
                                .AsQueryable();
            
            return await query.ToListAsync();
        }

        private void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _context.Dispose();
                }

                disposedValue = true;
            }
        }

        ~WorldService()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}