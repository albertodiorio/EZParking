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
    public class AddressRepository : GenericRepository<Address>, IAddressRepository
    {
        public AddressRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
