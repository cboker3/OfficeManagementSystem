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

namespace OfficeManagementSystem
{
    public partial class frmTasks : Form
    {
        Events currentEvent;
        Tasks currentTask;


        public frmTasks()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;

        }

        private void frmTasks_Load(object sender, EventArgs e)
        {

        }

        private void createTask(Events incEvent)
        {
            currentEvent = incEvent;

            this.Text += " for : " + incEvent.Name;
            throw new NotImplementedException();
        }

        private void editTask(Tasks incTask, Events incEvent)
        {
            currentEvent = incEvent;
            currentTask = incTask;

            this.Text += " for : " + incEvent.Name;



            throw new NotImplementedException();
        }

        private void lblDueDate_Click(object sender, EventArgs e)
        {

        }
    }
}
