using EZParking.Api.ParkingLot.Records;
using EZParking.Common.Infra.Services;
using EZParking.Domain.ParkingLots.Commands;
using EZParking.Domain.ParkingLots.Queries;
using Microsoft.AspNetCore.Mvc;


namespace EZParking.Api.Controllers.ParkingLot
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingLotController : ControllerBase
    {
        private readonly IMediatorService _mediatorService;

        public ParkingLotController(IMediatorService mediatorService)
        {
            _mediatorService = mediatorService;
        }

        [HttpGet]
        public async Task<ActionResult> Get(Guid parkingLotId)
        {
            var query = new GetParkingLotByIdQuery(parkingLotId);
            var result = await _mediatorService.Send(query);

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult> Add(ParkingLotRequest request)
        {

            var command = new CreateParkingLotCommand()
            {
                IsActive = true,
                FiscalCode = request.FiscalCode,
                Name = request.Name,

            };

            await _mediatorService.Send(command);

            return Ok();
        }

    }
}
