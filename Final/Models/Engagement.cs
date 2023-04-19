using System;
using System.Collections.Generic;

#nullable disable

namespace Final.Models
{
    public partial class Engagement
    {
        public long EngagementNumber { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string StartTime { get; set; }
        public string StopTime { get; set; }
        public byte[] ContractPrice { get; set; }
        public long? CustomerId { get; set; }
        public long? AgentId { get; set; }
        public long? EntertainerId { get; set; }
    }
}
