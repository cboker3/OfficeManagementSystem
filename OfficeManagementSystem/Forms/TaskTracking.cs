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

    public partial class TaskTracking : Form
    {
        OMScontext _OMScontext = new OMScontext();
        Users currentUser;

        public TaskTracking()
        {
            InitializeComponent();
        }

        public void displayTaskTracking(Users localUser)
        {
            currentUser = localUser;

            statusLabel1.Visible = true;

            switch(statusLabel1.Text)
            {
                case "0":
                    lblStatusDisplay.Text = "Completed";
                    break;
                case "1":
                    lblStatusDisplay.Text = "Not Completed";
                    break;
                case "2":
                    lblStatusDisplay.Text = "Pending";
                    break;
                default:
                    lblStatusDisplay.Text = "Error";
                    break;
            }

            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //_OMScontext.Tasks.ElementAt(tasksBindingSource.Position).Status = 0;
            statusLabel1.Text = "0";
            _OMScontext.SaveChanges();

        }

        private void TaskTracking_Load(object sender, EventArgs e)
        {
            // I don't understand this. Why does this work?
            _OMScontext.Tasks.Load();
            tasksBindingSource.DataSource = _OMScontext.Tasks.Local.ToBindingList();
        }

        private void tasksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            tasksBindingSource.EndEdit();
            _OMScontext.SaveChanges();
        }
    }
}
