using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Addresses
{
    public class CountryForResultDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
    }
}
