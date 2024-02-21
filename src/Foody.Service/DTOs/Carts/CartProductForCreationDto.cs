using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Carts
{
    public class CartProductForCreationDto
    {
        public long Quantity { get; set; }
        public decimal Price { get; set; }
        public long CartId { get; set; }
        public long ProductId { get; set; }
    }
}
