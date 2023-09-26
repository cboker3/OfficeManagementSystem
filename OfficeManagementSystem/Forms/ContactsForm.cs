using OfficeManagementSystem.Data;
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
    public partial class ContactsForm : Form
    {
        OMScontext _OMScontext = new OMScontext();
        Users currentUser;
        public ContactsForm()
        {
            InitializeComponent();
        }

        public void displayContactsForm(Users localUser)
        {
            currentUser = localUser;
            this.Show();
        }

        private void ContactsForm_Load(object sender, EventArgs e)
        {
            // I don't understand this. Why does this work?
            _OMScontext.Tasks.Load();
            contactsBindingSource.DataSource = _OMScontext.Contacts.Local.ToBindingList();
        }

        private void messagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            contactsBindingSource.EndEdit();
            _OMScontext.SaveChanges();
        }
    }
}
