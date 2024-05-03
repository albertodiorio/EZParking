using EZParking.Infrastructure.Context;
using EZParking.Domain.ParkingLots.Abstractions;


namespace EzParking.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _appDbContext;

        public UnitOfWork(AppDbContext appDbContext)
            => _appDbContext = appDbContext;         

        public bool Save() 
            => _appDbContext.SaveChanges() > 0;

        public void Dispose() 
            => _appDbContext.Dispose();
    }
}
