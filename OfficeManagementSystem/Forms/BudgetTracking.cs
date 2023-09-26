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
    public partial class BudgetTracking : Form
    {
        OMScontext _OMScontext = new OMScontext();
        Users currentUser;

        public BudgetTracking()
        {
            InitializeComponent();
        }

        public void displayBudgetTracking(Users localUser)
        {
            currentUser = localUser;
            this.Show();
        }

        private void budgetItemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            budgetItemsBindingSource.EndEdit();
            _OMScontext.SaveChanges();
        }

        private void BudgetTracking_Load(object sender, EventArgs e)
        {
            _OMScontext.BudgetItems.Load();
            budgetItemsBindingSource.DataSource = _OMScontext.BudgetItems.Local.ToBindingList();
        }
    }
}
