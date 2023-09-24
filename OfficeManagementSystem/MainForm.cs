using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using OfficeManagementSystem.Data;
using OfficeManagementSystem.Models;


namespace OfficeManagementSystem
{
    public partial class MainForm : Form
    {

        // Local Variables
        Users localUser = null; // Holds the current user for the system so we can send it around to other forms
        String pageTitle = "Event Management System"; // Holder for dynamic page title
        bool debug = true; // Allows us access to the Database so I can store and change items.

        int modifyIndex;
        int deleteIndex;

        Events selectedEvent;
        Tasks selectedTask;
        Venues selectedVenue;
        Users selectedUser;
        Contacts selectedContact;

        private const int MaxRows = 10;
        private int totalRows = 0;
        private int pages = 0;
        private int totalERows = 0;
        private int ePages = 0;

        OMScontext _OMScontext = new OMScontext();


        public MainForm()
        {
            InitializeComponent();

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // How do I have this activate after the form has been loaded?
            // UpdateUser();

            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            loadDataGridViewEvents();

            UpdateForm();

            //UpdateDataGrid();
        }

        private void userLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUser();

            UpdateForm();
        }

        private void UpdateForm()
        {
            debugToolStripMenuItem.Visible = debug;


            if (localUser != null)
            {
                // Should flip the first and last names. Make sure to change this after implementing database.
                this.Text = pageTitle + " [" + localUser.LastName + ", " + localUser.FirstName + "]";
            }
            else
            {
                this.Text = pageTitle;
            }

            

            //cbxExtra.Items
        }

        private void UpdateDataGrid()
        {

            //totalRows = _OMScontext.
            // I could make this more adaptable by making the queries be passed in, also
            // I could overload this function and create more dataGrids based on how many?

            // Clear existing columns
            dgvMain.Columns.Clear();


            // Queries the database for Events based on a select equry.
            // ADDITIONAL: Will have to also join on Venue for the name of the venue
            var query = from taskRecord in _OMScontext.Tasks
                        join eventRecord in _OMScontext.Events
                        on taskRecord.EventsID equals eventRecord.ID
                        select new
                        {
                            Priority = taskRecord.Priority,
                            Status = taskRecord.Status,
                            DueDate = taskRecord.DueDate,
                            Description = taskRecord.Description,
                            Name = eventRecord.Name
                        };

            // Load the query information into data variable and made into a list
            var data = query.ToList();
            // Link the data to the data source of the DataGridView.
            dgvMain.DataSource = data;
        }

        public void UpdateUser()
        {
            // Create another box, dialog box?
            // Request a name and and password and pass it back to the original form. 
            // Catch this, store inside localUser, set the text at the top of the screen.
            // Thoughts: Store this information, including the password, sending it back
            // and forth in order to verify each change without prompting the user again?

            // Create a method for changing the Title Text
            // Create a method for verifying the User.
            // Have a checkbox to keep the user signed in? Security issues*, maybe just the username?

            LoginForm newLogin = new LoginForm();

            localUser = newLogin.LoginUser(localUser);
            if (localUser != null)
                Debug.WriteLine(localUser.ToString());

            DialogResult inDialogResult = newLogin.DialogResult;
        }

        private void debugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DBdebugForm debugForm = new DBdebugForm();
            debugForm.Show();
        }

        private void eventDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {



            // EventForm editEventForm = new EventForm();
            // Need to verify if an event is selected.
            //editEventForm.editEvent(null);

        }

        private void eventsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Clear existing columns
            dgvMain.Columns.Clear();

            loadDataGridViewEvents();



            //using (OMScontext context = new OMScontext())
            //{
            //    var data = from eventRecord in _OMScontext.Events
            //               join eventCatRecord in _OMScontext.EventCategories
            //               on eventRecord.CategoryID equals eventCatRecord.ID
            //               join venueRecord in _OMScontext.Venues
            //               on eventRecord.VenuesID equals venueRecord.ID
            //               select new
            //               {
            //                   Name = eventRecord.Name,
            //                   Category = eventCatRecord.Name,
            //                   VenueName = venueRecord.Name,
            //                   Description = eventRecord.Description,
            //                   StartDate = eventRecord.StartDate,
            //                   EndDate = eventRecord.EndDate
            //               };

            //    dgvMain.DataSource = data.ToList();
            //    dgvMain.AutoGenerateColumns = true;
            //}

            //// Queries the database for Events based on a select equry.
            //// ADDITIONAL: Will have to join on Venue to get the Name of the Venue, and maybe address?????
            //var query = from eventRecord in _OMScontext.Events
            //            join eventCatRecord in _OMScontext.EventCategories
            //            on eventRecord.CategoryID equals eventCatRecord.ID
            //            select new
            //            {
            //                Name = eventRecord.Name,
            //                Category = eventCatRecord.Name
            //            };

            //// Load the query information into data variable and made into a list
            //var data = query.ToList();
            //// Link the data to the data source of the DataGridView.
            //dgvMain.DataSource = data;
        }

        private void createEventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EventForm createEventForm = new EventForm();
            createEventForm.createEvent();

        }

        private void tasksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Clear existing columns
            dgvMain.Columns.Clear();

            using (OMScontext context = new OMScontext())
            {
                var data = from eventRecord in _OMScontext.Events
                           join taskRecord in _OMScontext.Tasks
                           on eventRecord.ID equals taskRecord.EventsID
                           select new
                           {
                               Name = eventRecord.Name,
                               Description = taskRecord.Description,
                               DueDate = taskRecord.DueDate,
                               Priority = taskRecord.Priority,
                               Status = taskRecord.Status
                           };

                dgvMain.DataSource = data.ToList();
                dgvMain.AutoGenerateColumns = true;
            }
        }

        private void venuesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Clear existing columns
            dgvMain.Columns.Clear();

            using (OMScontext context = new OMScontext())
            {
                var data = from venuesRecord in _OMScontext.Venues
                           select new
                           {
                               Name = venuesRecord.Name,
                               Address = venuesRecord.Address,
                               Capacity = venuesRecord.Capacity,
                               CompanyOwned = venuesRecord.CompanyOwned
                           };

                dgvMain.DataSource = data.ToList();
                dgvMain.AutoGenerateColumns = true;
            }
        }

        private void contactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear existing columns
            dgvMain.Columns.Clear();

            using (OMScontext context = new OMScontext())
            {
                var data = from contactsRecord in _OMScontext.Contacts
                           select new
                           {
                               FirstName = contactsRecord.FirstName,
                               LastName = contactsRecord.LastName,
                               Email = contactsRecord.Email,
                               DueDate = contactsRecord.Phone,
                               Priority = contactsRecord.Organization,
                           };

                dgvMain.DataSource = data.ToList();
                dgvMain.AutoGenerateColumns = true;
            }
        }

        private void resourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear existing columns
            dgvMain.Columns.Clear();

            using (OMScontext context = new OMScontext())
            {
                //var data = from resourcesRecord in _OMScontext.Resources
                //           select new
                //           {
                //               Name = resourcesRecord.Name,
                //               Description = resourcesRecord.Description,
                //               Quantity = resourcesRecord.Quantity,
                //           };

                var data = context.Resources.ToList();
                Debug.WriteLine(data.ToString());

                dgvMain.DataSource = data.ToList();
                foreach(var item in data)
                {
                    Debug.WriteLine(item.ToString());
                }
                dgvMain.AutoGenerateColumns = true;
            }
        }

        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void loadDataGridViewEvents()
        {
            List<string> extra = new List<string>{"ID","CategoryID",
                "EventCategories", "Attendees", "Tasks",
                "Resources", "BudgetItems", "Contacts", "VenuesID",
                "Venues"};

            var eventsSet = _OMScontext.Events.OrderBy(p => p.StartDate).ToList();
            dgvMain.DataSource = eventsSet;
            
            // Trying to create paging system.
            totalRows = eventsSet.Count();
            pages = totalRows / MaxRows;
            if(totalRows % MaxRows != 0)
            {
                pages += 1;
            }
            lblPages.Text = "/ " + pages;

            DisplayEvents(1);

            // End of Paging System.

            foreach(DataGridViewColumn column in dgvMain.Columns)
            {
                foreach(string header in extra)
                {
                    if (column.HeaderText.Equals(header))
                        column.Visible = false;
                }
                if (column.HeaderText.Equals("StartDate") || column.HeaderText.Equals("EndDate"))
                    column.DefaultCellStyle.Format = "MM/dd/yy";
            }

            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                UseColumnTextForButtonValue = true,
                Text = "Delete"
            };
            deleteIndex = dgvMain.Columns.Count;
            dgvMain.Columns.Add(deleteColumn);

            DataGridViewButtonColumn modifyColumn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                UseColumnTextForButtonValue = true,
                Text = "Modify"
            };
            modifyIndex = dgvMain.Columns.Count;
            dgvMain.Columns.Add(modifyColumn);

            Debug.WriteLine(dgvMain.Columns.Count);
            Debug.WriteLine("Delete: " + deleteIndex);
            Debug.WriteLine("Modify: " + modifyIndex);

            dgvMain.Columns[2].Width = 220;
            //dgvMain.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;



        }

        private void DisplayEvents(int pageNumber)
        {
            tbxPage.Text = pageNumber.ToString();int skip = MaxRows * (pageNumber - 1);

            int take = MaxRows;
            if(pageNumber == pages)
            {
                take = totalRows - skip;
            }
            if (totalRows <= MaxRows)
            {
                take = totalRows;
            }
            //throw new NotImplementedException();
            EnableDisableButtons(pageNumber);
        }

        private void EnableDisableButtons(int pageNumber)
        {
            if(pageNumber == 1)
            {
                btnFirst.Enabled = false;
                btnPrev.Enabled = false;
            }
            else
            {
                btnFirst.Enabled = true;
                btnPrev.Enabled = true;
            }

            if(pageNumber == pages)
            {
                btnNext.Enabled = false;
                btnLast.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
                btnLast.Enabled = true;
            }
            if (totalRows <= MaxRows)
                btnGoTo.Enabled = false;

        }

        /// <summary>
        /// dgvMain_CellContentClick
        /// Uses the created buttons to throw an event which finds the associatated selected
        /// event and throws it to the appropriate other method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMain_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Debug.WriteLine("Total Columns: " + dgvMain.Columns.Count);
            Debug.WriteLine("Clicked location: " + e.ColumnIndex);
            using(OMScontext context = new OMScontext())
            {
                int eventID = Convert.ToInt32(dgvMain.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                selectedEvent = context.Events.Find(eventID);
                selectedEvent = context.Events.First(p => p.ID == Convert.ToInt32(eventID));

                if (e.ColumnIndex == modifyIndex || e.ColumnIndex == deleteIndex)
                { 
                    Debug.WriteLine("Row Index: " + e.RowIndex);
                    Debug.WriteLine("Row Index: " + dgvMain.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                }
                if (e.ColumnIndex == modifyIndex)
                {
                    Debug.WriteLine("Modify");
                    EventForm editEvent = new EventForm();
                    editEvent.editEvent(selectedEvent);
                    //ModifyEvent();
                }

                else if (e.ColumnIndex == deleteIndex)
                {
                    //Debug.WriteLine("Delete");
                    //DeleteProduct();
                } else
                {
                    // Load up dgvExtra with relative information based on what's in the cbxExtra
                    // Throw selectedEvent at a different method to populate the dgvExtra

                }
            }
        }

        private void addVenueImage()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //layoutDiagramPictureBox.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void SwitchTo(String tableName)
        {
            _OMScontext.Events.Load();
            dgvMain.DataSource =
                _OMScontext.Events.Local.ToBindingList();
            var currentTableType = typeof(Events);


            // Clear existing columns
            dgvMain.Columns.Clear();

            // Create columns for each property in the entity
            foreach (var property in currentTableType.GetProperties())
            {
                // Add a DataGridViewTextBoxColumn for each property
                var column = new DataGridViewTextBoxColumn
                {
                    HeaderText = property.Name,
                    DataPropertyName = property.Name
                };
                dgvMain.Columns.Add(column);
            }

            // Set the DataSource to refresh the DataGridView
            // databaseDataGridView.DataSource = currentTable.ToList();
        }

        private void tcbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {

        }
    }
}
