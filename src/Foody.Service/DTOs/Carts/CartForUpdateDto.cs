using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Carts
{
    public class CartForUpdateDto
    {
        public decimal TotalPrice { get; set; }
        public long UserId { get; set; }
    }
}
