using EZParking.Common.Messaging;

namespace EZParking.Common.Security.Users.Commands
{
    public class LoginCommand : ICommand<bool>
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
