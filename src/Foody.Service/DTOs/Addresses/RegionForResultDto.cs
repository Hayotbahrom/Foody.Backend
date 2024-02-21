using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Addresses
{
    public class RegionForResultDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public CountryForResultDto Country { get; set; }
    }
}
