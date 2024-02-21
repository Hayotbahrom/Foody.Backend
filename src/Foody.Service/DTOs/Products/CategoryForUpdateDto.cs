using Foody.Domain.Entities.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Products
{
    public class CategoryForUpdateDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public long ProductId { get; set; }
    }
}
