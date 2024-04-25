using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZParking.Domain.ParkingLots.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {
        public IParkingLotRepository ParkingLotRepository { get; }
        public IAddressRepository AddressRepository { get; }
        bool Save();
    }
}
