using System;
using System.Collections.Generic;

#nullable disable

namespace Final.Models
{
    public partial class MusicalPreference
    {
        public long? CustomerId { get; set; }
        public long? StyleId { get; set; }
        public long? PreferenceSeq { get; set; }
    }
}
