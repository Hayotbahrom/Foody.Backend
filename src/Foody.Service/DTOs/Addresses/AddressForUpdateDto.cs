using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Addresses
{
    public class AddressForUpdateDto
    {
        public string Street { get; set; }
        public string Floor { get; set; }
        public string Home { get; set; }
        public string DoorCode { get; set; }

        public long CountryId { get; set; }

        public long RegionId { get; set; }

        public long DistrictId { get; set; }
    }
}
