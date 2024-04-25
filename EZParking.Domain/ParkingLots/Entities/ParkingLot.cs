using EZParking.Core.DomainObjects;
using EZParking.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZParking.Domain.ParkingLots.Entities
{
    public sealed class ParkingLot: Entity, IAggregateRoot
    {

        public string? Name { get; private set; }
        public string? FiscalCode { get; private set; }
        public bool IsActive { get; private set; }

        private readonly List<Address> _addresses = [];

    



        //public IReadOnlyCollection<Address> Addresses => _addresses;

        //public ParkingLot(int parkingLotId, string name, string fiscalCode)
        //{
        //    ValidationDomain.When(parkingLotId < 0,
        //        "Invalid Id value.");
        //    Validate(name, fiscalCode);
        //}

        //private ParkingLot()
        //{

        //}

        //public ParkingLot Create()
        //    => new();

        //public ParkingLot(string name, string fiscalCode)
        //{
        //    Name = name;
        //    FiscalCode = fiscalCode;


        //    Validate(Name, FiscalCode);
        //}
        //public void Inativar()
        //    => IsActive = false;

        //public void Ativar()
        //    => IsActive |= true;

        //public void Update(string name, string fiscalCode)
        //    => Validate(name, fiscalCode);

        //private static void Validate(string name, string fiscalCode)
        //{
        //    ValidationDomain.When(string.IsNullOrEmpty(name),
        //        "Name is required.");

        //    ValidationDomain.When(name.Length < 5,
        //        "Name must contain 5 characters at least.");

        //    ValidationDomain.When(string.IsNullOrEmpty(fiscalCode),
        //        "Fiscal Code is required");
        //}

    }
}
