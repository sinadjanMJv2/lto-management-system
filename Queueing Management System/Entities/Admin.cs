using System;
using System.Collections.Generic;

namespace Queueing_Management_System.Entities
{
    public partial class Admin
    {
        public int AdminId { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
    }
}
