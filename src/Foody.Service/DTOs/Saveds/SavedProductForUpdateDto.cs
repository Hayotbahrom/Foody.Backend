using Foody.Domain.Entities.Products;
using Foody.Domain.Entities.Saved;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Saveds
{
    public class SavedProductForUpdateDto
    {
        public long SavedId { get; set; }
        public long ProductId { get; set; }
    }
}
