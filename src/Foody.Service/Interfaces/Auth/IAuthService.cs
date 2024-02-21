using Foody.Service.DTOs.Auth;

namespace Foody.Service.Interfaces.Auth
{
    public interface IAuthService
    {
        public Task<LoginForResultDto> AuthenticateAsync(LoginForCreationDto dto);
    }
}
