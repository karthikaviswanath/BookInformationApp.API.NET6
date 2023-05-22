using BookInformationApp.API.DTOs;
using Microsoft.AspNetCore.Identity;

namespace BookInformationApp.API.Interfaces
{
    public interface IAuthService
    {
        Task<IEnumerable<IdentityError>> Register(BookApiUserDto userDto);
        Task<AuthResponseDto> Login(LoginDto loginDto);
        Task<string> CreateRefreshToken();
        Task<AuthResponseDto> VerifyRefreshToken(AuthResponseDto request);
    }
}
