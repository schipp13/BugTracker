using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    internal class Bug
    {
        public int BugId { get; set; }
        public int UserId { get; set; }
        public int ProgrammerId { get; set; }
        public string SoftwareName { get; set; }
        public string SoftwareVersion { get; set; }
        public string BugIssue { get; set; }
        public string CurrentStatus { get; set; }
        public string Severity { get; set; }
        public DateTime ReportedTime { get; set; }
        public DateTime ResolvedTime { get; set; }
        public string TimeToResolution { get; set; }
        public string ReplicateBugSteps { get; set; }
        public string Notes { get; set; }

    }
}
