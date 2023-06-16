using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ErrorOr;

namespace BuberDinner.Domain.Common.Errors
{
    public static class Errors
    {
        public static class User
        {
            public static Error DuplicateEmail => Error.Conflict(code: "User.DuplicateEmail", description: "User with given email already exists.");
        }
        
    }
}