using EZParking.Common.Infra.Services;
using EZParking.Domain.ParkingLots.Abstractions;
using EZParking.Domain.ParkingLots.Commands;
using EZParking.Domain.ParkingLots.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace EZParking.Api.Controllers
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
        public async Task<ActionResult> Get(int parkingLotId)
        {
            

            return Ok(parkingLot);
        }

        [HttpPost]
        public async Task<ActionResult> Add(ParkingLotRecord parkingLot)
        {

            var command = new CreateParkingLotCommand();
            await _mediatorService.Send(command);

            return Ok();
        }

        public record ParkingLotRecord(string Name, string FiscalCode);

    }
}
