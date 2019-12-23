using System;
using System.Collections.Generic;

namespace BlazorServerArcane.Models
{
    public partial class BugReports
    {
        public int BugId { get; set; }
        public int UsrId { get; set; }
        public string BugSubject { get; set; }
        public string BugLog { get; set; }
        public DateTime BugTime { get; set; }
    }
}
