using EZParking.Api.ParkingLot.Records;
using EZParking.Common.Infra.Services;
using EZParking.Common.Security.Users.Commands;
using Microsoft.AspNetCore.Mvc;

namespace EZParking.Api.Security
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : Controller
    {
        private readonly IMediatorService _mediatorService;

        public SecurityController(IMediatorService mediatorService)
        {
            _mediatorService = mediatorService;
        }

        [HttpPost]
        public async Task<ActionResult> Add(CreateUser user)
        {
            var command = new CreateUserCommand()
            {
                UserName = user.Name,
                Password = user.Password,
                Email = user.Email,
            };

            var result = await _mediatorService.Send(command);

            if(result.IsSuccess)
                return Ok(result);
            return BadRequest(result);
        }

        public record CreateUser(string Name, string Password, string Email);
    }
}
