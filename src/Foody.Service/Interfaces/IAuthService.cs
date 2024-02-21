using Foody.Service.DTOs.Auth;

namespace Foody.Service.Interfaces
{
    public interface IAuthService
    {
        public Task<LoginForResultDto> AuthenticateAsync(LoginForCreationDto dto);
    }
}
