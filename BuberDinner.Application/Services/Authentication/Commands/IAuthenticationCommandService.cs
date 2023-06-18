using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Application.Services.Authentication;
using BuberDinner.Application.Services.Authentication.Common;
using ErrorOr;
using FluentResults;

namespace BuberDinner.Application.Services.Authentication.Commands
{
    public interface IAuthenticationCommandService
    {
        ErrorOr<AuthenticationResult> Register(string firstName, string lastName, string email, string password);
    }
}