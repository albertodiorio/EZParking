using EZParking.Common.Queries;
using EZParking.Common.Validations;
using EZParking.Domain.ParkingLots.Abstractions;
using EZParking.Domain.ParkingLots.Queries;

namespace EZParking.Application.ParkingLots.QueryHandlers
{
    internal class GetParkingLotByIdQueryHandler : IQueryHandler<GetParkingLotByIdQuery, GetParkingLotByIdQueryResult>
    {
        private readonly IParkingLotRepository _parkingLotRepository;

        public GetParkingLotByIdQueryHandler(IParkingLotRepository parkingLotRepository)
        {
            _parkingLotRepository = parkingLotRepository;
        }

        public async Task<Result<GetParkingLotByIdQueryResult>> Handle(GetParkingLotByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _parkingLotRepository.GetParkingLotBySql(request.Id);

            return new GetParkingLotByIdQueryResult(result.Id, result.Name, result.FiscalCode);

        }
    }
}
