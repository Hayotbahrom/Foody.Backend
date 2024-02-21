using Foody.Domain.Entities.Products;
using Foody.Domain.Entities.Saved;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Saveds
{
    public class SavedProductForResultDto
    {
        public long Id { get; set; }
        public Saved Saved { get; set; }
        public Product Product { get; set; }
    }
}
