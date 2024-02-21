using Foody.Domain.Commons;

namespace Foody.Domain.Entities.Addresses
{
    public class District : Auditable
    {
        public string Name { get; set; }
        public long RegionId { get; set; }
        public Region Region { get; set; }
    }
}
