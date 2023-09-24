using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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

using OfficeManagementSystem.Essential;
using Validator = OfficeManagementSystem.Essential.Validator;

namespace OfficeManagementSystem
{
    public partial class MainForm : Form
    {

        /// <summary>
        /// Local Variables
        /// </summary>
        Users localUser = null; // Holds the current user for the system so we can send it around to other forms
        String pageTitle = "Event Management System"; // Holder for dynamic page title
        bool debug = true; // Allows us access to the Database so I can store and change items.

        // Used in the DataGridView as points of changing events
        int modifyIndex;
        int deleteIndex;
        int deleteEIndex;
        // May need to add additional for extra datagrid...

        // Used to store related objects to the context
        Events selectedEvent;
        Tasks selectedTask;
        Venues selectedVenue;
        Users selectedUser;
        Contacts selectedContact;
        Attendees selectedAttendee;

        // Used for the paging system
        private const int MaxRows = 10;
        private int totalRows = 0;
        private int pages = 0;
        private int totalERows = 0;
        private int ePages = 0;

        // Used for keeping out certain columns.
        List<string> extra = new List<string>{"ID","CategoryID",
                "EventCategories", "Attendees", "Tasks",
                "Resources", "BudgetItems", "Contacts", "VenuesID",
                "Venues", "EventsID", "Events", };

        //
        string[] comboEventRelations = { "Attendees", "Tasks", "BudgetItems", "Resources" };

        // Database context (Although it's not being used as much with the using statements...)
        OMScontext _OMScontext = new OMScontext();
        private BudgetItems selectedBudgetItem;
        private Resources selectedResource;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            // How do I have this activate after the form has been loaded?
            // UpdateUser();

            dgvMain.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Trying to create paging system.
            var eventsSet = _OMScontext.Events.OrderBy(p => p.StartDate).ToList();
            totalRows = eventsSet.Count();
            pages = totalRows / MaxRows;
            if (totalRows % MaxRows != 0)
            {
                pages += 1;
            }
            lblPages.Text = "/ " + pages;

            DisplayEvents(1);

            // End of Paging System.

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

            // Filling up the combobox
            foreach (string item in comboEventRelations)
                cbxExtra.Items.Add(item);

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


        private void loadDataGridViewEvents(int skip, int take)
        {
            dgvMain.Columns.Clear();

            List<string> extra = new List<string>{"ID","CategoryID",
                "EventCategories", "Attendees", "Tasks",
                "Resources", "BudgetItems", "Contacts", "VenuesID",
                "Venues", "EventsID", "Events", };

            var eventsSet = _OMScontext.Events.OrderBy(p => p.StartDate).Skip(skip).Take(take).ToList();
            dgvMain.DataSource = eventsSet;

            // Only displaying the columns that need to be displayed
            foreach(DataGridViewColumn column in dgvMain.Columns)
            {
                foreach(string header in extra)
                {
                    if (column.HeaderText.Equals(header))
                        column.Visible = false;
                }
                if (column.HeaderText.Equals("StartDate") || column.HeaderText.Equals("EndDate"))
                    column.DefaultCellStyle.Format = "MM/dd/yy";
                // Could potentially edit columns as they are being found and comparing them with 
                // the header text from inside this iterative group.

            }

            // Creating the Delete and Modify Columns
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

            //Debug.WriteLine(dgvMain.Columns.Count);

            // Formating the DataGridView
            dgvMain.AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue;
            dgvMain.Columns[2].Width = 220;
            //dgvMain.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Pre-Select the first row, so there isn't a null exception thrown if the combobox for extra is changed first.
            dgvMain.Rows[0].Selected = true;
            //int eventID = Convert.ToInt32(dgvMain.Rows[0].Cells[0].Value.ToString().Trim());
            //selectedEvent = _OMScontext.Events.Find(eventID);
            //selectedEvent = _OMScontext.Events.First(p => p.ID == Convert.ToInt32(eventID));
        }

        private void DisplayEvents(int pageNumber)
        {
            tbxPage.Text = pageNumber.ToString();
            
            int skip = MaxRows * (pageNumber - 1);

            int take = MaxRows;
            if(pageNumber == pages)
            {
                take = totalRows - skip;
            }
            if (totalRows <= MaxRows)
            {
                take = totalRows;
            }

            loadDataGridViewEvents(skip, take);
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
            //Debug.WriteLine("Click!");
            //Debug.WriteLine("Total Columns: " + dgvMain.Columns.Count);
            //Debug.WriteLine("Clicked location: " + e.ColumnIndex);
            using(OMScontext context = new OMScontext())
            {
                /*
                 * Moved to SelectionChanged event to make it more responsive.
                int eventID = Convert.ToInt32(dgvMain.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                selectedEvent = context.Events.Find(eventID);
                selectedEvent = context.Events.First(p => p.ID == Convert.ToInt32(eventID));
                */

                // Placeholder if statement to check if a button was clicked
                if (e.ColumnIndex == modifyIndex || e.ColumnIndex == deleteIndex)
                { 
                    //Debug.WriteLine("Row Index: " + e.RowIndex);
                    //Debug.WriteLine("Row Index: " + dgvMain.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                }

                // Cascading if, checking which part of the row is clicked, Delete or Modified
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
                    DeleteEvent();
                } else
                {
                    // Load up dgvExtra with relative information based on what's in the cbxExtra
                    // Throw selectedEvent at a different method to populate the dgvExtra

                }
            }
            // Moved to SelectionChanged
            //loadExtraDataGrid();
        }

        private void DeleteEvent()
        {
            throw new NotImplementedException();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            DisplayEvents(1);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            int pageNumber = Convert.ToInt32(tbxPage.Text);
            pageNumber -= 1;
            DisplayEvents(pageNumber);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            int pageNumber = Convert.ToInt32(tbxPage.Text);
            pageNumber += 1;
            DisplayEvents(pageNumber);
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            DisplayEvents(pages);
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            if(IsMainGotoValidData())
            {
                int pageNumber = Convert.ToInt32(tbxPage.Text);
                DisplayEvents(pageNumber);
            }
        }

        private bool IsMainGotoValidData()
        {
            return
                Validator.IsPresent(tbxPage) &&
                Validator.IsInteger(tbxPage);
            //throw new NotImplementedException();
        }

        /// <summary>
        ///  Extra Data Grid View
        ///  
        /// Displays associated items with the events that are selected. 
        /// </summary>

        private void cbxExtra_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadExtraDataGrid();
        }

        private void loadExtraDataGrid()
        {
            dgvExtra.Columns.Clear();

            //Debug.WriteLine("cbxExtra.Text: " + cbxExtra.Text);
            //Debug.WriteLine("selectedEvent.ID: " + selectedEvent.ID);
            switch (cbxExtra.Text)
            {
                case "":
                    return;
                    break;
                case "Attendees":
                    _OMScontext.Attendees.Load();
                    dgvExtra.DataSource =
                        _OMScontext.Attendees.Where(p => p.EventsID == selectedEvent.ID).ToList();
                    break;
                case "Tasks":
                    _OMScontext.Tasks.Load();
                    dgvExtra.DataSource =
                        _OMScontext.Tasks.Where(p => p.EventsID == selectedEvent.ID).ToList();
                    break;
                case "BudgetItems":
                    _OMScontext.BudgetItems.Load();
                    dgvExtra.DataSource =
                        _OMScontext.BudgetItems.Where(p => p.EventsID == selectedEvent.ID).ToList();
                    break;
                case "Resources":
                    _OMScontext.Resources.Load();
                    dgvExtra.DataSource =
                        _OMScontext.Resources.Where(p => p.EventsID == selectedEvent.ID).ToList();
                    break;
                default:
                    Debug.WriteLine("Welp!");
                    throw new Exception("Welp.");
                    break;
            }

            foreach (DataGridViewColumn column in dgvExtra.Columns)
            {
                foreach (string header in extra)
                {
                    if (column.HeaderText.Equals(header))
                        column.Visible = false;
                }
                if (column.HeaderText.Contains("Date"))
                    column.DefaultCellStyle.Format = "MM/dd/yy";
                // Could potentially edit columns as they are being found and comparing them with 
                // the header text from inside this iterative group.

                /* Use this to take the int values for the data values and replace them with words
                 * Do this for Priority and Status.
                 * Can also do this for the "paid" status of attendees. 
                 * var combobox = (DataGridViewComboBoxColumn)dgvExtra.Columns["Priority"]
                 * combobox.DisplayMember = "Name";
                 * combobox.ValueMember = "ID";
                 * combobox.DataSource = Get"list"
                 * 
                 */
            }
            // Creating the Delete and Modify Columns
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
            {
                HeaderText = "",
                UseColumnTextForButtonValue = true,
                Text = "Delete"
            };
            deleteEIndex = dgvExtra.Columns.Count;
            dgvExtra.Columns.Add(deleteColumn);
        }

        private void dgvExtra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvExtra.CurrentCell != null && e.RowIndex > 0)
            {
                switch (cbxExtra.Text)
                {
                    case "":
                        break;
                    case "Attendees":
                        int attendeesID = Convert.ToInt32(dgvMain.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                        selectedAttendee = _OMScontext.Attendees.First(p => p.ID == Convert.ToInt32(attendeesID));
                        // Cascading if, checking which part of the row is clicked, Delete or Modified
                        if (e.ColumnIndex == deleteEIndex)
                        {
                            //Debug.WriteLine("Delete");
                            _OMScontext.Attendees.Remove(selectedAttendee);
                        }
                        break;
                    case "Tasks":
                        int tasksID = Convert.ToInt32(dgvExtra.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                        selectedTask = _OMScontext.Tasks.First(p => p.ID == Convert.ToInt32(tasksID));
                        // Cascading if, checking which part of the row is clicked, Delete or Modified
                        if (e.ColumnIndex == deleteEIndex)
                        {
                            _OMScontext.Tasks.Remove(selectedTask);
                        }
                        break;
                    case "BudgetItems":
                        int budgetItemsID = Convert.ToInt32(dgvExtra.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                        selectedBudgetItem = _OMScontext.BudgetItems.First(p => p.ID == Convert.ToInt32(budgetItemsID));
                        // Cascading if, checking which part of the row is clicked, Delete or Modified
                        if (e.ColumnIndex == deleteEIndex)
                        {
                            _OMScontext.BudgetItems.Remove(selectedBudgetItem);
                        }
                        break;
                    case "Resources":
                        int ResourcesID = Convert.ToInt32(dgvExtra.Rows[e.RowIndex].Cells[0].Value.ToString().Trim());
                        selectedResource = _OMScontext.Resources.First(p => p.ID == Convert.ToInt32(ResourcesID));
                        // Cascading if, checking which part of the row is clicked, Delete or Modified
                        if (e.ColumnIndex == deleteEIndex)
                        {
                            _OMScontext.Resources.Remove(selectedResource);
                        }
                        break;
                    default:
                        Debug.WriteLine("Welp!");
                        throw new Exception("Welp.");
                        break;
                }
            }
        }

        private void dgvMain_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvMain.SelectedRows.Count != 0)
            {
                int eventID = Convert.ToInt32(dgvMain.SelectedRows[0].Cells[0].Value.ToString().Trim());
                selectedEvent = _OMScontext.Events.Find(eventID);
                selectedEvent = _OMScontext.Events.First(p => p.ID == Convert.ToInt32(eventID));
                loadExtraDataGrid();
            }

            // If the selection changes, stop editing
            //dgvExtra.BeginEdit(false);

        }

        private void dgvExtra_SelectionChanged(object sender, EventArgs e)
        {
            // If the selection changes, stop editing
            //dgvExtra.BeginEdit(false);
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!(dgvExtra.CurrentCell == null))
            {
                dgvExtra.BeginEdit(true);
            } else
            {
                MessageBox.Show("Please select a cell to edit.");
            }
        }

        private void dgvExtra_DataSourceChanged(object sender, EventArgs e)
        {
            // MAGIC! FREAKING MAGIC
            // Why does this save the changes even if I immediately exit the program after making the change?!?!
            _OMScontext.SaveChanges();
        }
    }
}
