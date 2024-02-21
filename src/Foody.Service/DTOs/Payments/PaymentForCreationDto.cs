using Foody.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foody.Service.DTOs.Payments
{
    public class PaymentForCreationDto
    {
        public PaymentType PaymentType { get; set; }
        public decimal Amount { get; set; }
    }
}
