using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuberDinner.Application.Authentication.Commands.Register;
using BuberDinner.Application.Services.Authentication.Common;
using ErrorOr;
using MediatR;

namespace BuberDinner.Application.Common.Behaviors
{
    public class ValidateRegisterCommandBehavior : IPipelineBehavior<RegisterCommand, ErrorOr<AuthenticationResult>>
    {
        public async Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand request, RequestHandlerDelegate<ErrorOr<AuthenticationResult>> next, CancellationToken cancellationToken)
        {
            var  result = await next();
            return result;
        }
    }
}