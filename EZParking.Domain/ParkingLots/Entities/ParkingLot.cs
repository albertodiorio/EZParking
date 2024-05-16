using EZParking.Core.DomainObjects;


namespace EZParking.Domain.ParkingLots.Entities
{
    public sealed class ParkingLot : Entity, IAggregateRoot
    {

        public string? Name { get; private set; }
        public string? FiscalCode { get; private set; }
        public bool IsActive { get; private set; }

        private readonly List<Address> _addresses = [];

        public IReadOnlyCollection<Address> Addresses => _addresses;

        private ParkingLot()
        {

        }

        public ParkingLot(string name, string fiscalCode)
        {
            Name = name;
            FiscalCode = fiscalCode;
        }

        public void Inativar()
            => IsActive = false;

        public void Ativar()
            => IsActive = false;

    }
}
