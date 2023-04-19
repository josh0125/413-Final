using System;
using System.Collections.Generic;

#nullable disable

namespace Final.Models
{
    public partial class EntertainerStyle
    {
        public long? EntertainerId { get; set; }
        public long? StyleId { get; set; }
        public long? StyleStrength { get; set; }
    }
}
