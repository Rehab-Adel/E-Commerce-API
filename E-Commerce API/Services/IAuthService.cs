using System.Threading.Tasks;
using E_Commerce_API.DTOs;

namespace E_Commerce_API.Services
{
    public interface IAuthService
    {
        Task<bool> RegisterUserAsync(RegisterDto registerDto);
        Task<string> LoginUserAsync(LoginDto loginDto);
    }
}
