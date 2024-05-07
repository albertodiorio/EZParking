using EZParking.Common.Messaging;
using EZParking.Common.Validations;
using EZParking.Domain.ParkingLots.Abstractions;
using EZParking.Domain.ParkingLots.Commands;
using EZParking.Domain.ParkingLots.Entities;

namespace EZParking.Application.ParkingLots.CommandHandlers
{
    public class CreateParkingLotCommandHandler : ICommandHandler<CreateParkingLotCommand, bool>
    {
        private readonly IParkingLotRepository _parkingLotRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateParkingLotCommandHandler(IParkingLotRepository parkingLotRepository,
            IUnitOfWork unitOfWork)
        {
            _parkingLotRepository = parkingLotRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<bool>> Handle(CreateParkingLotCommand request, CancellationToken cancellationToken)
        {
            var parkingLot = new ParkingLot(request.Name, request.FiscalCode);
            await _parkingLotRepository.AddAsync(parkingLot);
            bool result = _unitOfWork.Save();

            return result;

        }
    }
}
