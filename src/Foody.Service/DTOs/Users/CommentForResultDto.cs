using Foody.Domain.Entities.Products;
using Foody.Domain.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Users
{
    public class CommentForResultDto
    {
        public long Id { get; set; }
        public string Text { get; set; }
        public byte Rating { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }
    }
}
