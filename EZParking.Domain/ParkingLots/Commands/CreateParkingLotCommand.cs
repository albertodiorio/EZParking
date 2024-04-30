using EZParking.Common.Messaging;
using EZParking.Domain.ParkingLots.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EZParking.Domain.ParkingLots.Commands
{
    public class CreateParkingLotCommand : ICommand
    {
        public string Name { get; set; }
        public string FiscalCode { get; set; }
        public bool IsActive { get; set; }

    }
}
