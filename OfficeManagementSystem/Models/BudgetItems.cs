using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagementSystem.Models
{
    internal class BudgetItems
    {
        public int BudgetItemID { get; set; }
        public int EventID { get; set; }
        public string Decription { get; set; }
        public decimal Amount { get; set; }
        public int Type { get; set; }
        public DateTime Date { get; set; }

        public Events Events { get; set; }
    }
}
