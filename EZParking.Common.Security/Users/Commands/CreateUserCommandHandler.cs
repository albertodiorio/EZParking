using EZParking.Common.Messaging;
using EZParking.Common.Validations;
using Microsoft.AspNetCore.Identity;

namespace EZParking.Common.Security.Users.Commands
{
    public class CreateUserCommandHandler(UserManager<ApplicationUser> userManager) : ICommandHandler<CreateUserCommand, CreateUserCommandResult>
    {
        private readonly UserManager<ApplicationUser> _userManager = userManager;

        public async Task<Result<CreateUserCommandResult>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new ApplicationUser
            {
                Email = request.Email,
                UserName = request.Email,
                PhoneNumber = request.Phone
            };

            var result = await _userManager
                .CreateAsync(user, request.Password)
                .WaitAsync(cancellationToken);

            if (!result.Succeeded)
                return Result.Failure<CreateUserCommandResult>(new Error("CreateUser.Errors", result.Errors.ToString()));

            var response = new CreateUserCommandResult()
            {
                Id = user.Id,
                Email = user.Email
            };

            return Result.Success(response);
        }
    }
}
