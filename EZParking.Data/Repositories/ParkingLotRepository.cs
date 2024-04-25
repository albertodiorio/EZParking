using EZParking.Data.Context;
using EZParking.Domain.ParkingLots.Abstractions;
using EZParking.Domain.ParkingLots.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZParking.Data.Repositories
{
    public class ParkingLotRepository : GenericRepository<ParkingLot>, IParkingLotRepository
    {
        public ParkingLotRepository(AppDbContext appDbContext) : base(appDbContext) 
        { 
        
        }
     
    }
}
