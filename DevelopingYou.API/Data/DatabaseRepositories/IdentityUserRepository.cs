using DevelopingYou.API.Data.Interfaces;
using DevelopingYou.API.Models;
using DevelopingYou.API.Models.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DevelopingYou.API.Data.DatabaseRepositories
{
    public class IdentityUserRepository : IUserRepository
    {
        private readonly UserManager<User> userManager;
        private readonly JwtTokenService tokenService;

        public IdentityUserRepository(UserManager<User> userManager, JwtTokenService tokenService)
        {
            this.userManager = userManager;
            this.tokenService = tokenService;
        }

        public async Task<UserWithToken> Authenticate(string username, string password)
        {
            var user = await userManager.FindByNameAsync(username);

            if (!await userManager.CheckPasswordAsync(user, password))
                return null;

            return await GetUserWithToken(user);
        }

        public async Task<UserDTO> GetUser(ClaimsPrincipal user)
        {
            return await userManager.GetUserAsync(user);
        }

        public async Task<UserWithToken> Register(RegisterUser data, ModelStateDictionary modelState)
        {
            var user = new User
            {
                Email = data.Email,
                UserName = data.UserName,
            };

            var result = await userManager.CreateAsync(user, data.Password);

            if (result.Succeeded)
                return await GetUserWithToken(user);

            foreach (var error in result.Errors)
            {
                var errorKey =
                    error.Code.Contains("Password") ? nameof(data.Password) :
                    error.Code.Contains("Email") ? nameof(data.Email) :
                    error.Code.Contains("UserName") ? nameof(data.UserName) :
                    "";
                modelState.AddModelError(errorKey, error.Description);
            }

            return null;
        }

        private async Task<UserWithToken> GetUserWithToken(User user)
        {
            return new UserWithToken
            {
                Id = user.Id,
                UserName = user.UserName,
                Token = await tokenService.GetToken(user, TimeSpan.FromMinutes(60))
            };
        }
    }
}
