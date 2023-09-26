using OfficeManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OfficeManagementSystem.Data;
using OfficeManagementSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace OfficeManagementSystem.Forms
{
    public partial class InternalMessage : Form
    {
        OMScontext _OMScontext = new OMScontext();
        Users currentUser;

        public InternalMessage()
        {
            InitializeComponent();
        }

        public void displayInternalMessage(Users localUser)
        {
            currentUser = localUser;
            this.Show();
        }

        private void InternalMessage_Load(object sender, EventArgs e)
        {
            _OMScontext.Messages.Load();
            messagesBindingSource.DataSource = _OMScontext.Messages.Local.ToBindingList();
            // Need to use this:
            // .Where(f => f.ReceiverID == currentUser.ID
            // To only get the messages being sent to this user.
        }
    }
}
