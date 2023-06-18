using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Application.Services.Authentication;
using ErrorOr;
using FluentResults;

namespace BuberDinner.Application.Services.Commands.Authentication
{
    public interface IAuthenticationCommandService
    {
        ErrorOr<AuthenticationResult> Register(string firstName, string lastName, string email, string password);
    }
}