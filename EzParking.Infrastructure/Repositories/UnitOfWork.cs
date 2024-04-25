using EzParking.Infrastructure.Context;
using EZParking.Domain.ParkingLots.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EzParking.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;

        public IParkingLotRepository ParkingLotRepository { get; private set; }
        public IAddressRepository AddressRepository { get; private set; }

        public UnitOfWork(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
            ParkingLotRepository = new ParkingLotRepository(_appDbContext);
            AddressRepository = new AddressRepository(_appDbContext);
        }

        public bool Save() 
            => _appDbContext.SaveChanges() > 0;

        public void Dispose() 
            => _appDbContext.Dispose();
    }
}
