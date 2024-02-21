using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Addresses
{
    public class RegionForCreationDto
    {
        public string Name { get; set; }
        public long CountryId { get; set; }
    }
}
