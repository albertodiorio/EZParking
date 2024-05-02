namespace EZParking.Domain.ParkingLots.Abstractions
{
    public interface IUnitOfWork : IDisposable
    {   
        bool Save();
    }
}
