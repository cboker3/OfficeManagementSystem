﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeManagementSystem.Models
{
    internal class Messages
    {
        public int MessageID { get; set; }
        public int SenderID { get; set; }
        public int ReceiverID { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public DateTime Timestamp { get; set; }

        public Users Users { get; set; }


    }
}
