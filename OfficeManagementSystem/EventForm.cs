using Microsoft.Extensions.Logging.Abstractions;
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

namespace OfficeManagementSystem
{
    public partial class EventForm : Form
    {
        OMScontext _OMScontext = new OMScontext();

        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
        private void createEvents()
        {
            // Transform some controls based on which function is called. 
            btnEdit.Visible = false;
            
            // Queries the database for Events based on a select equry.
            var query = from venueRecord in _OMScontext.Venues
                        select new
                        {
                            Name = venueRecord.Name,
                        };

            // Load the query information into data variable and made into a list
            var data = query.ToList();
            // Link the data to the data source of the DataGridView.
            cbxVenueSelect.DataSource = data;
            cbxVenueSelect.DisplayMember = "Name";
            cbxVenueSelect.ValueMember = "ID";



            this.ShowDialog();

        }

        private void editEvents(Events editEvent)
        {

        }
    }
}
