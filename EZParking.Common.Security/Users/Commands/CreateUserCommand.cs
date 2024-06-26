﻿using EZParking.Common.Messaging;

namespace EZParking.Common.Security.Users.Commands
{
    public class CreateUserCommand : ICommand<CreateUserCommandResult>
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
        public string? Phone { get; set; }
    }
}
