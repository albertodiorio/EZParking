using EZParking.Domain.ParkingLots.Abstractions;
using EZParking.Domain.ParkingLots.Entities;
using EZParking.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace EzParking.Infrastructure.Repositories
{
    public class ParkingLotRepository : Repository<ParkingLot>, IParkingLotRepository
    {
        public ParkingLotRepository(AppDbContext appDbContext) : base(appDbContext)
        {

        }

        public Task<ParkingLot> GetParkingLotBySql(Guid id)
        {

            var parameters = new object[1];
            parameters.SetValue(id, 0);

            var sql = string.Format("SELECT * FROM PARKINGLOT WHERE ID = '{0}'", parameters.GetValue(0));

            var result = _appDbContext.ParkingLots.FromSqlRaw(sql.ToString(), parameters).FirstOrDefault();

            return Task.FromResult(result);
        }
    }
}
