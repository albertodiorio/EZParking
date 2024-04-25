using EZParking.Domain.ParkingLots.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZParking.Domain.ParkingLots.Commands
{
    public class CreateParkingLotCommand : IRequest<ParkingLot>
    {
        public string Name { get; set; }
        public string FiscalCode { get; set; }
        public bool IsActive { get; set; }  
    }
}
