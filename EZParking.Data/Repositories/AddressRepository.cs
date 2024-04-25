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
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
