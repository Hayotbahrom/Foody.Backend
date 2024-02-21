using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Restaurants
{
    public class RestaurantForResultDto
    {
        public long Id { get; set; }
        public string RestaurantName { get; set; }
        public string Description { get; set; }
    }
}
