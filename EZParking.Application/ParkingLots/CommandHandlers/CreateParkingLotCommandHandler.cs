using EZParking.Domain.ParkingLots.Commands;
using EZParking.Domain.ParkingLots.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZParking.Application.ParkingLots.CommandHandlers
{
    public class CreateParkingLotCommandHandler : IRequestHandler<CreateParkingLotCommand, ParkingLot>
    {
        public Task<ParkingLot> Handle(CreateParkingLotCommand command, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
