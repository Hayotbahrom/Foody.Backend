using Foody.Service.DTOs.Addresses;

namespace Foody.Service.Interfaces.Adresses;

public interface IRegionService
{
    Task<RegionForResultDto> AddAsync(RegionForCreationDto dto);
}
