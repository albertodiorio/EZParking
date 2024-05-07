using EZParking.Common.Infra.Services;
using EZParking.Domain.ParkingLots.Abstractions;
using EZParking.Domain.ParkingLots.Commands;
using EZParking.Domain.ParkingLots.Entities;
using EZParking.Domain.ParkingLots.Queries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace EZParking.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EzController : ControllerBase
    {
        private readonly IMediatorService _mediatorService;

        public EzController(IMediatorService mediatorService)
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
        public async Task<ActionResult> Add(ParkingLotRecord parkingLot)
        {

            var command = new CreateParkingLotCommand()
            {
                IsActive = true,
                FiscalCode = parkingLot.FiscalCode,
                Name = parkingLot.Name,
                
            };

            await _mediatorService.Send(command);

            return Ok();
        }

        public record ParkingLotRecord(string Name, string FiscalCode);

    }
}
