using EZParking.Common.Messaging;


namespace EZParking.Domain.ParkingLots.Commands
{
    public class CreateParkingLotCommand : ICommand<bool>
    {
        public string? Name { get; set; }
        public string? FiscalCode { get; set; }
        public bool IsActive { get; set; }

    }
}
