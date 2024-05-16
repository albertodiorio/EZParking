using EZParking.Common.Messaging;
using EZParking.Common.Validations;
using Microsoft.AspNetCore.Identity;

namespace EZParking.Common.Security.Users.Commands
{
    public sealed class LoginCommandHandler(SignInManager<ApplicationUser> signInManager) : ICommandHandler<LoginCommand, bool>
    {
        private readonly SignInManager<ApplicationUser> _signInManager = signInManager;

        public async Task<Result<bool>> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var result = await _signInManager
                .PasswordSignInAsync(request.Email, request.Password, isPersistent: false, lockoutOnFailure: false)
                .WaitAsync(cancellationToken);

            if (result.Succeeded)
                return Result.Success(true);

            return Result.Failure<bool>(new Error("Login.LockedOut", result.ToString()));
        }
    }
}
