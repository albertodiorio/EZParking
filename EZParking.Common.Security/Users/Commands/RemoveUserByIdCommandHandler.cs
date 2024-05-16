using EZParking.Common.Messaging;
using EZParking.Common.Validations;
using Microsoft.AspNetCore.Identity;

namespace EZParking.Common.Security.Users.Commands
{
    public class RemoveUserByIdCommandHandler(UserManager<ApplicationUser> userManager) : ICommandHandler<RemoveUserByIdCommand>
    {
        private readonly UserManager<ApplicationUser> _userManager = userManager;

        public async Task<Result> Handle(RemoveUserByIdCommand request, CancellationToken cancellationToken)
        {
            var task = _userManager.FindByIdAsync(request.Id.ToString());

            if (task.Result == null)
                return Result.Failure(new Error("User.NotFound", $"The user with Id {request.Id} was not found."));

            var result = await _userManager.DeleteAsync(task.Result);


            if (result.Succeeded)
                return Result.Success(result);

            return Result.Failure(new Error("User.RemoveError", result.Errors.First().Description));
        }
    }
}
