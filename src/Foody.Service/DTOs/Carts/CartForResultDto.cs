using Foody.Service.DTOs.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Carts
{
    public class CartForResultDto
    {
        public long Id { get; set; }
        public decimal TotalPrice { get; set; }
        public UserForCreationDto User { get; set; }
    }
}
