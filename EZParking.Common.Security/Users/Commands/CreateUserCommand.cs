using EZParking.Common.Messaging;
using Microsoft.AspNetCore.Identity;

namespace EZParking.Common.Security.Users.Commands
{
    public class CreateUserCommand : ICommand<IdentityResult>
    {
        public string? UserName { get; set; }
        public string? Email { get; set; }   
        public string? Password { get; set; }
        public string? Phone { get; set; }
        public bool TwoFactorEnabled { get;set; }
    }
}
