﻿using System;
using Jp.Domain.Core.Commands;

namespace Jp.Domain.Commands.User
{
    public abstract class UserCommand : Command
    {
        public Guid Id { get; protected set; }
        public string Email { get; protected set; }
        public string PhoneNumber { get; protected set; }
        public string Name { get; protected set; }
        public string Username { get; protected set; }
        public string Password { get; protected set; }
        public string ConfirmPassword { get; protected set; }
        public string Picture { get; protected set; }   
        public string Provider { get; protected set; }
        public string ProviderId { get; protected set; }
    }
}
