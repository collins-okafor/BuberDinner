using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Application.Services.Authentication;
using ErrorOr;
using FluentResults;

namespace BuberDinner.Application.Services.Queries.Authentication
{
    public interface IAuthenticationQueryService
    {
       ErrorOr<AuthenticationResult> Login(string email, string password);

    }
}