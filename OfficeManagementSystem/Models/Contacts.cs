using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Use this with the brackets like [Key]
//System.ComponentModel.DataAnnotations;

namespace OfficeManagementSystem.Models
{
    public class Contacts
    {
        // These are using Conventions for relationship discovery. Not explicitly programmed.
        // The conventions described here can be overridden by explicit configuration of the relationship using either mapping attributes or the model building API.
        // It is explained here: https://learn.microsoft.com/en-us/ef/core/modeling/

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Organization { get; set; }

        // Navigations Property
        public ICollection<Events> Events { get; } = new List<Events>();
    }
}
