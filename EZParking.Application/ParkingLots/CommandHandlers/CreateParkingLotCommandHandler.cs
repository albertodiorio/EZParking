using EZParking.Common.Messaging;
using EZParking.Common.Validations;
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
    public class CreateParkingLotCommandHandler : ICommandHandler<CreateParkingLotCommand>
    {
        public Task<Result> Handle(CreateParkingLotCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
