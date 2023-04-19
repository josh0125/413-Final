using System;
using System.Collections.Generic;

#nullable disable

namespace Final.Models
{
    public partial class ZtblMonth
    {
        public string MonthYear { get; set; }
        public long? YearNumber { get; set; }
        public long? MonthNumber { get; set; }
        public string MonthStart { get; set; }
        public string MonthEnd { get; set; }
        public long? January { get; set; }
        public long? February { get; set; }
        public long? March { get; set; }
        public long? April { get; set; }
        public long? May { get; set; }
        public long? June { get; set; }
        public long? July { get; set; }
        public long? August { get; set; }
        public long? September { get; set; }
        public long? October { get; set; }
        public long? November { get; set; }
        public long? December { get; set; }
    }
}
