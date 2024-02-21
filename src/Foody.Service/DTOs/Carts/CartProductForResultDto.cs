using Foody.Service.DTOs.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Carts
{
    public class CartProductForResultDto
    {
        public long Id { get; set; }
        public long Quantity { get; set; }
        public decimal Price { get; set; }

        public CartForCreationDto Cart { get; set; }
        public ProductForCreationDto Product { get; set; }
    }
}
