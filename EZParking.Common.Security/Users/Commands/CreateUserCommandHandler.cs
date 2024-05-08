using EZParking.Common.Messaging;
using EZParking.Common.Validations;
using EZParking.Domain.Errors;
using Microsoft.AspNetCore.Identity;

namespace EZParking.Common.Security.Users.Commands
{
    public class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, IdentityResult>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public CreateUserCommandHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<Result<IdentityResult>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new ApplicationUser
            {
                UserName = request.UserName,
                Email = request.Email,
                PasswordHash = request.Password,
                PhoneNumber = request.Phone,
                TwoFactorEnabled = request.TwoFactorEnabled
            };

            var result = await _userManager.CreateAsync(user).WaitAsync(cancellationToken);

            if (result.Succeeded)
                return Result.Success(result);
            else
                return Result.Failure<IdentityResult>(DomainErrors.Teste.EmptyName);


        }
    }
}
