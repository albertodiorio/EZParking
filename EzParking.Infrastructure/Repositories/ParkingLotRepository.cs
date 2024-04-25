using EzParking.Infrastructure.Context;
using EZParking.Domain.ParkingLots.Abstractions;
using EZParking.Domain.ParkingLots.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzParking.Infrastructure.Repositories
{
    public class ParkingLotRepository : Repository<ParkingLot>, IParkingLotRepository
    {
        public ParkingLotRepository(AppDbContext appDbContext) : base(appDbContext) 
        { 
        
        }
     
    }
}
