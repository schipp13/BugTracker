using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BugTracker.Models
{
    internal class Programmer : Person
    {       
        public int ProgrammerId { get; set; }
        public string PermissionLevel { get; set; }
    }

}
