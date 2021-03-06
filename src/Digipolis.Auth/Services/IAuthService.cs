﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Digipolis.Auth.Services
{
    public interface IAuthService
    {
        ClaimsPrincipal User { get; }
        Task<string> LogOutAsync(ControllerContext controllerContext, string redirectController, string redirectAction);
    }
}
