using System;
using System.Collections.Generic;

#nullable disable

namespace Final.Models
{
    public partial class Member
    {
        public long MemberId { get; set; }
        public string MbrFirstName { get; set; }
        public string MbrLastName { get; set; }
        public string MbrPhoneNumber { get; set; }
        public string Gender { get; set; }
    }
}
