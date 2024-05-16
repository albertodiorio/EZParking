using EZParking.Core.DomainObjects;
using EZParking.Domain.ParkingLots.Entities;

namespace EZParking.Domain.ParkingLots.Abstractions
{
    public interface IParkingLotRepository : IRepository<ParkingLot>
    {
        Task<ParkingLot> GetParkingLotBySql(Guid id);
    }
}
