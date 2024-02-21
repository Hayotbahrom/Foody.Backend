using Foody.Domain.Entities.Products;
using Foody.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Users
{
    public class CommentForUpdateDto
    {
        public long ProductId { get; set; }
        public long UserId { get; set; }
        public string Text { get; set; }
        public byte Rating { get; set; }
    }
}
