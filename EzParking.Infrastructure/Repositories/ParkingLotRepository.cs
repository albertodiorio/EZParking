using EZParking.Infrastructure.Context;
using EZParking.Domain.ParkingLots.Abstractions;
using EZParking.Domain.ParkingLots.Entities;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace EzParking.Infrastructure.Repositories
{
    public class ParkingLotRepository : Repository<ParkingLot>, IParkingLotRepository
    {
        public ParkingLotRepository(AppDbContext appDbContext) : base(appDbContext)
        {
           
        }

        public IEnumerable<ParkingLot> GetParkingLotBySql(Guid id)
        {
            var sql = new StringBuilder();
            sql.Append("SELECT * FROM PARKINGLOT WHERE ID = :ID");

            var parameters = Array.Empty<object>();
            parameters.SetValue(id, 0);

            var result = _appDbContext.ParkingLots.FromSqlRaw(sql.ToString(), parameters);

            foreach(var item in result) 
                yield return item;
        }
    }
}
