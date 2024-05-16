using EZParking.Core.DomainObjects;
using EZParking.Domain.ParkingLots.Entities;

namespace EZParking.Domain.ParkingLots.Abstractions
{
    public interface IAddressRepository : IRepository<Address>
    {
        long ObterAlgo(int id);
    }
}
