using EZParking.Common.Messaging;

namespace EZParking.Common.Security.Users.Commands
{
    public class UpdateUserCommand : ICommand
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? PassWord { get; set; }
    }
}
