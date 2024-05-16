using EZParking.Common.Messaging;
using EZParking.Common.Validations;
using Microsoft.AspNetCore.Identity;

namespace EZParking.Common.Security.Roles
{
    public sealed class CreateRoleCommandHandler(RoleManager<IdentityRole> roleManager) : ICommandHandler<CreateRoleCommand, string>
    {
        private readonly RoleManager<IdentityRole> _roleManager = roleManager;

        public async Task<Result<string>> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            var role = new IdentityRole(request.Role);
            var result = await _roleManager
                .CreateAsync(role)
                .WaitAsync(cancellationToken);

            if (result.Succeeded)
                return Result.Success(role.Id);

            return Result.Failure<string>(new Error("CreateRole.Errors", result.Errors.ToString()));
        }
    }
}
