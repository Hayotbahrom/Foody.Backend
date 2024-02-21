using Foody.Domain.Entities.Products;
using Foody.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Saveds
{
    public class SavedForResultDto
    {
        public long Id { get; set; }
        public User User { get; set; }
    }
}
