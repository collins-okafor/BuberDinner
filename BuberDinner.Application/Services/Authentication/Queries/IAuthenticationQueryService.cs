using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Application.Services.Authentication;
using BuberDinner.Application.Services.Authentication.Common;
using ErrorOr;
using FluentResults;

namespace BuberDinner.Application.Services.Authentication.Queries
{
    public interface IAuthenticationQueryService
    {
       ErrorOr<AuthenticationResult> Login(string email, string password);

    }
}