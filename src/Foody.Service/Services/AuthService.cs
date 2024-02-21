using Foody.Service.DTOs.Auth;
using Foody.Service.Interfaces.Auth;

namespace Foody.Service.Services;

public class AuthService : IAuthService
{
    public Task<LoginForResultDto> AuthenticateAsync(LoginForCreationDto dto)
    {
        throw new NotImplementedException();
    }
}
