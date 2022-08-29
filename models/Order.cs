using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order_Management_System___OODJ.models
{
    internal class Order : BaseEntity
    {
        public int UserId { get; set; }
        public string OrderStatus { get; set; }
        public decimal OrderTotal { get; set; }
    }
}