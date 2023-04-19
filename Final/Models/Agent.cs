using System;
using System.Collections.Generic;

#nullable disable

namespace Final.Models
{
    public partial class Agent
    {
        public long AgentId { get; set; }
        public string AgtFirstName { get; set; }
        public string AgtLastName { get; set; }
        public string AgtStreetAddress { get; set; }
        public string AgtCity { get; set; }
        public string AgtState { get; set; }
        public string AgtZipCode { get; set; }
        public string AgtPhoneNumber { get; set; }
        public string DateHired { get; set; }
        public byte[] Salary { get; set; }
        public byte[] CommissionRate { get; set; }
    }
}
