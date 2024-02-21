using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Auth
{
    public class LoginForResultDto
    {
        public string Token { get; set; }
        public string Role { get; set; }
    }
}
