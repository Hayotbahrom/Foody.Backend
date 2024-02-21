using Foody.Domain.Entities.Orders;
using Foody.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Orders
{
    public class OrderItemForResultDto
    {
        public long Id { get; set; }
        public long Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Summ { get; set; }
        public Order Order { get; set; }

        public Product Product { get; set; }
    }
}
