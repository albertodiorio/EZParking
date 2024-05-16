using EZParking.Common.Messaging;

namespace EZParking.Common.Security.Roles
{
    public class CreateRoleCommand : ICommand<string>
    {
        public required string Role { get; set; }
    }
}
