using EZParking.Domain.ParkingLots.Abstractions;
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
        private readonly IUnitOfWork _unitOfWork;

        public ParkingLotController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult> Get(int parkingLotId)
        {
            var parkingLot = await _unitOfWork.ParkingLotRepository.GetByFilter(c => c.Id == parkingLotId);

            return Ok(parkingLot);
        }

        [HttpPost]
        public async Task<ActionResult> Add(ParkingLotRecord parkingLot)
        {
            var pl = new ParkingLot(parkingLot.Name, parkingLot.FiscalCode, true);
             await _unitOfWork.ParkingLotRepository.AddAsync(pl);
            _unitOfWork.Save();

            return Ok();
        }

        public record ParkingLotRecord(string Name, string FiscalCode);

    }
}
