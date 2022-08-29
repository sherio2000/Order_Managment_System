using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Order_Management_System___OODJ.models
{
    internal class Users : BaseEntity
    {
        public string UserFullName { get; set; }
        public string UserPassword { get; set; }
        public string UserEmail { get; set; }
        public string UserName { get; set; }
        public string UserRole { get; set; }
    }
}
