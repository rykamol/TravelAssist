using Microsoft.EntityFrameworkCore;
using TravelAssist.Core.Models;
using TravelAssist.Core.Repository_Interface;
using TravelAssist.Data._Context;
using TravelAssist.Data.Base_Repository;

namespace TravelAssist.Data.Repository
{
    public class SpotRepository : Repository<Spot>, ISpotRepository
    {

        public SpotRepository(DbContext context) : base(context) { }

        private TravelDbContext dbContext { get { return Context as TravelDbContext; } }
    }
}
