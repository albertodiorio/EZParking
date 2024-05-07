using EZParking.Common.Queries;

namespace EZParking.Domain.ParkingLots.Queries
{
    public sealed record GetParkingLotByIdQuery(Guid Id) : IQuery<GetParkingLotByIdQueryResult>
    {

    }
}
