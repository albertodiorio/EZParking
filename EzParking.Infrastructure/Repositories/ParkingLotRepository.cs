using EZParking.Infrastructure.Context;
using EZParking.Domain.ParkingLots.Abstractions;
using EZParking.Domain.ParkingLots.Entities;

namespace EzParking.Infrastructure.Repositories
{
    public class ParkingLotRepository : Repository<ParkingLot>, IParkingLotRepository
    {
        public ParkingLotRepository(AppDbContext appDbContext) : base(appDbContext)
        { 
        
        }
     
    }
}
