using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.ViewModel
{
    public class OrderModel
    {
        [Key]
        public Guid OrderId { get; set; }
        public string ProductName { get; set; }
        public string CardNumber { get; set; }
        public string UserId { get; set; }
    }
}
