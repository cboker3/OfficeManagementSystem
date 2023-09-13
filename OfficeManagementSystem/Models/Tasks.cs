using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagementSystem.Models
{
    internal class Tasks
    {
        public int TaskID { get; set; }
        public int EventID { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public int Priority { get; set; } // Change to a byte?
        public int Status { get; set; } // Change to a byte? 

        public Events Events { get; set; }
    }
}
