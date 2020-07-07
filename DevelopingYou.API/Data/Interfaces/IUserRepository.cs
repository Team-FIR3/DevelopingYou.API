using DevelopingYou.API.Models.DTOs;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DevelopingYou.API.Data.Interfaces
{
    public interface IUserRepository
    {
        Task<UserWithToken> Authenticate(string userName, string password);
        Task<UserDTO> GetUser(ClaimsPrincipal user);
        Task<UserWithToken> Register(RegisterUser data, ModelStateDictionary modelState);
    }
}
