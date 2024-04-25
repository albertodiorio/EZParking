using EZParking.Core.DomainObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZParking.Domain.ParkingLots.Entities
{
    public sealed class Address: Entity, IAggregateRoot
    {
        public string? Street { get; private set; } 
        public string? Number { get; private set; } 
        public string? City { get; private set; }
        public string? State { get; private set; } 
        public string? PostalCode { get; private set; } 
        public ParkingLot ParkingLot { get; private set; } 
    }
}
