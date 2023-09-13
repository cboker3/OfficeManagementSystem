using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagementSystem.Models
{
    internal class Resources
    {
        public int ResourceID { get; set; }
        public int EventID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }

        public Events Events { get; set; }
    }
}
