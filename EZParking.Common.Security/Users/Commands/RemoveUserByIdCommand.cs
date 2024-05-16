

using EZParking.Common.Messaging;

namespace EZParking.Common.Security.Users.Commands
{
    public class RemoveUserByIdCommand : ICommand
    {
        public Guid Id { get; set; }
    }
}
