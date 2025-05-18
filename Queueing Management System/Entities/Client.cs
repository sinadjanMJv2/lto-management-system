using System;
using System.Collections.Generic;

namespace Queueing_Management_System.Entities
{
    public partial class Client
    {
        public int ClientId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public string ValidId { get; set; }
        public string Gmail { get; set; }
        public int? Age { get; set; }
    }
}
