using System;
using System.Collections.Generic;

#nullable disable

namespace Final.Models
{
    public partial class EntertainerMember
    {
        public long? EntertainerId { get; set; }
        public long? MemberId { get; set; }
        public long? Status { get; set; }
    }
}
