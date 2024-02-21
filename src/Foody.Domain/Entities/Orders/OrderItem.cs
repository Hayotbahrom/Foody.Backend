﻿using Foody.Domain.Commons;
using Foody.Domain.Entities.Carts;
using Foody.Domain.Entities.Products;

namespace Foody.Domain.Entities.Orders
{
    public class OrderItem :Auditable
    {
        public long Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Summ { get; set; }

        public long OrderId { get; set; }
        public Order Order { get; set; }

        public long ProductId { get; set; }
        public Product Product { get; set; }
    }
}
