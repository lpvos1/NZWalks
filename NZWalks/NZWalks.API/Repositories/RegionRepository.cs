using Microsoft.EntityFrameworkCore;
using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {

        public RegionRepository(NZWalksDbContext nZWalksDbContext)
        {
            this.NZWalksDbContext = nZWalksDbContext;
        }

        public NZWalksDbContext NZWalksDbContext { get; }

        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await NZWalksDbContext.Regions.ToListAsync();
        }
    }
}
