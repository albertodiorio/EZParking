using EZParking.Infrastructure.Context;
using EZParking.Domain.ParkingLots.Abstractions;
using EZParking.Domain.ParkingLots.Entities;


namespace EzParking.Infrastructure.Repositories
{
    public class AddressRepository(AppDbContext appDbContext) : Repository<Address>(appDbContext), IAddressRepository
    {
        public long ObterAlgo(int id)
        {
            throw new NotImplementedException();
        }
    }
}
