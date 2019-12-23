using System;
using System.Collections.Generic;

namespace BlazorServerArcane.Models
{
    public partial class Accounts
    {
        public int AccId { get; set; }
        public string AccName { get; set; }
        public string AccPassword { get; set; }
        public string AccEmail { get; set; }
        public sbyte AccValidated { get; set; }
        public string AccCode { get; set; }
        public int AccLastUserId { get; set; }
        public int AccGems { get; set; }
        public int AccStatus { get; set; }
        public DateTime AccCreationTime { get; set; }
    }
}
