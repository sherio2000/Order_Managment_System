using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order_Management_System___OODJ.models
{
    internal class OrderItem : BaseEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
    }
}
