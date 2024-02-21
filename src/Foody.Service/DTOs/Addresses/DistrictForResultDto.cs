namespace Foody.Service.DTOs.Addresses
{
    public class DistrictForResultDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public RegionForResultDto Region { get; set; }
    }
}
