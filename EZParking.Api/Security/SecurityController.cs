using EZParking.Api.Security.Requests;
using EZParking.Common.Infra.Services;
using EZParking.Common.Security.Roles;
using EZParking.Common.Security.Users.Commands;
using Microsoft.AspNetCore.Mvc;

namespace EZParking.Api.Security
{
    [Route("[controller]")]
    [ApiController]
    public partial class SecurityController(IMediatorService mediatorService) : Controller
    {
        private readonly IMediatorService _mediatorService = mediatorService;

        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult> Add([FromBody] CreateUser user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var command = new CreateUserCommand()
            {
                Email = user.Email,
                Password = user.Password,
                Phone = user.Phone
            };

            var result = await _mediatorService.Send(command);

            if (result.IsSuccess)
                return CreatedAtAction(nameof(Add), new { id = result.Value.Id, email = result.Value.Email });

            return BadRequest(result.Value);
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult> Login([FromBody] LoginUser loginUser)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var command = new LoginCommand()
            {
                Email = loginUser.Email,
                Password = loginUser.Password
            };

            var result = await _mediatorService.Send(command);

            return Ok(result.Value);

        }

        [HttpPost]
        [Route("Role/Create")]
        public async Task<ActionResult> Add([FromBody] CreateRole role)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var command = new CreateRoleCommand()
            {
                Role = role.Role
            };

            var result = await _mediatorService.Send(command);

            if (result.IsSuccess)
                return CreatedAtAction(nameof(Add), new { id = result.Value });

            return BadRequest(result);
        }

        [HttpDelete]
        [Route("RemoveUser/{id}")]
        public async Task<ActionResult> RemoveById(Guid id)
        {
            var command = new RemoveUserByIdCommand()
            {
                Id = id
            };

            var result = await _mediatorService.Send(command);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);

        }

        [HttpPut]
        [Route("UpdateUser/{id}")]
        public async Task<ActionResult> Update(Guid id, [FromBody] UpdateUser updateUser)
        {
            var command = new UpdateUserCommand()
            {
                Id = id,
                Name = updateUser.Name,
                PassWord = updateUser.Password
            };

            var result = await _mediatorService.Send(command);

            if (result.IsSuccess)
                return Ok(result);

            return BadRequest(result);
        }
    }
}
