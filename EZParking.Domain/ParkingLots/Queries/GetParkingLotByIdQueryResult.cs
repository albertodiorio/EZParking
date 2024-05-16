namespace EZParking.Domain.ParkingLots.Queries
{
    public sealed record GetParkingLotByIdQueryResult(Guid Id, string Name, string FiscalCode);

}
