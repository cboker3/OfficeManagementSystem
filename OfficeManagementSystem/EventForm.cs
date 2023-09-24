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

using OfficeManagementSystem.Essential;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Remoting.Contexts;
using System.Diagnostics;

namespace OfficeManagementSystem
{
    public partial class EventForm : Form
    {
        OMScontext _OMScontext = new OMScontext();
        Events currentEvent;
        Bitmap venueImage;

        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            tbxAddress.Enabled = false;
            tbxCapacity.Enabled = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(IsValidData())
            {
                DialogResult result = MessageBox.Show("Would you like to create this event?", "Create Event?", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    using (OMScontext context = new OMScontext())
                    {
                        // Needs to check if the Venue already exists
                        var existingEvent = context.Events.FirstOrDefault(p => p.Name.Equals(cbxVenueSelect.Text) && p.StartDate.Equals(dtpStartDate));

                        if ((existingEvent != null))
                        {
                            // Kicks out if the Venue table already has something with the same name. 
                            MessageBox.Show("Event with the same name already Exists");
                            return;
                        }

                        // If not, if it is validated and not on the list, create one. Save changes. Exit
                        Events addEvent = new Events();
                        addEvent.Name = tbxName.Text;
                        addEvent.Description = tbxDescription.Text;

                        var retrieveEventCat = context.EventCategories.FirstOrDefault(p => p.Name.Equals(cbxEventCat.Text));
                        addEvent.CategoryID = retrieveEventCat.ID;

                        var retrieveVenue = context.Venues.FirstOrDefault(p => p.Name.Equals(cbxVenueSelect.Text));
                        addEvent.VenuesID = retrieveVenue.ID;

                        addEvent.StartDate = dtpStartDate.Value;
                        addEvent.EndDate = dtpEndDate.Value;


                        context.SaveChanges();

                        context.Events.Add(addEvent);
                        context.SaveChanges();

                        this.DialogResult = MessageBox.Show("Event: \"" + addEvent.Name + "\" has been created!");
                    }
                } else if (result == DialogResult.No)
                {
                    this.DialogResult = result;
                }
            }
        }

        public void createEvent()
        {
            // Editing Title
            this.Text = "Create " + this.Text;

            // Transform some controls based on which function is called. 
            btnEdit.Visible = false;
            btnAddVenue.Visible = false;

            dtpStartDate.MinDate = DateTime.Today;
            dtpEndDate.MinDate = DateTime.Today;

            // Queries the database for Events based on a select equry.
            /*var query = from venueRecord in _OMScontext.Venues
                        select new
                        {
                            Name = venueRecord.Name,
                            Capacity = venueRecord.Capacity,
                            Address = venueRecord.Address,
                            Layout = venueRecord.LayoutDiagram
                        };
            */
            var query = _OMScontext.Venues.ToList();
            // Load the query information into data variable and made into a list
            var data = query.ToList();
            // Link the data to the data source of the DataGridView.
            //cbxVenueSelect.DataSource = data;
            //cbxVenueSelect.DisplayMember = "Name";
            //cbxVenueSelect.ValueMember = "ID";

            // Queries the database for Events based on a select equry.
            using (OMScontext context = new OMScontext())
            {
                var query2 = context.EventCategories.OrderBy(ec => ec.Name).ToList();

                // Load the query information into data variable and made into a list
                var data2 = query2.ToList();
                // Link the data to the data source of the DataGridView.
                //cbxEventCat.DataSource = data2;
                //cbxEventCat.DisplayMember = "Name";
                //cbxVenueSelect.ValueMember = "ID";
            }

            // Need to insert a query on Venue usage. If an Event is going on in a certain Venue,
            // should not be able to pick a time that Venue is being used. 

            UpdateComboBox();

            this.ShowDialog();

        }

        public void editEvent(Events editEvent)
        {
            // Editing Title
            this.Text = "Edit " + this.Text;
            UpdateComboBox();

            // Transform some controls based on which function is called. 
            btnEdit.Visible = true;
            btnCreate.Visible = false;
            btnAddVenue.Visible = false;
            currentEvent = editEvent;

            using(OMScontext context = new OMScontext())
            {
                var query = from eventRecord in _OMScontext.Events
                            join eventCatRecord in _OMScontext.EventCategories
                            on eventRecord.CategoryID equals eventCatRecord.ID
                            join venueRecord in _OMScontext.Venues
                            on eventRecord.VenuesID equals venueRecord.ID
                            where eventRecord.ID == editEvent.ID
                            select new
                            {
                                EventName = eventRecord.Name,
                                VenueName = venueRecord.Name,
                                EventDescription = eventRecord.Description,
                                VenueCapacity = venueRecord.Capacity,
                                VenueAddress = venueRecord.Address,
                                VenueImage = venueRecord.LayoutDiagram,
                                Category = eventCatRecord.Name,
                                EventStartDate = eventRecord.StartDate,
                                EventEndDate = eventRecord.EndDate
                            };

                // MIGHT want to load a try catch here to catch errors
                // Load the query information into data variable and made into a list
                var data = query.ToList();

                tbxName.Text = editEvent.Name;
                tbxDescription.Text = editEvent.Description;

                dtpStartDate.Value = editEvent.StartDate;
                dtpEndDate.Value = editEvent.EndDate;

                cbxEventCat.SelectedIndex = cbxEventCat.Items.IndexOf(data.First().Category);

                
                if(cbxVenueSelect.Items.IndexOf(data.First().VenueName) == -1)
                {
                    tbxAddress.Text = data.First().VenueAddress;
                    tbxCapacity.Text = data.First().VenueCapacity.ToString();
                    cbxVenueSelect.Text = data.First().VenueName;
                    //venueImage = data.First().VenueImage;
                }else
                {
                    foreach (var item in cbxVenueSelect.Items)
                    {
                        // Check if the item's ValueMember (assuming it's a string) matches the target value
                        if (item.ToString().Equals(data.First().VenueName))
                        {
                            // Set the SelectedValue property to the matched ValueMember
                            cbxVenueSelect.SelectedIndex = cbxVenueSelect.Items.IndexOf(data.First().VenueName);
                            break; // Exit the loop once a match is found
                        }
                    }
                }
            }
                // Failed attempt to try and use the data source and bind the information to another portion
                //cbxVenueSelect.DataSource = _OMScontext.Venues.ToList();
                //cbxVenueSelect.ValueMember = "ID";
                //cbxVenueSelect.DisplayMember = "Name";
            this.Show();
        }

        private void dtpStartDate_ValueChanged(object sender, EventArgs e)
        {
            // Could potential change it to keep consistent the amount of time between the two dates.
            // Not sure if this would be helpful to change, or to keep as is.

            // Moves the EndDate to be on the same day as the StartDate so there's not an EndDate before StartDate.
            // Ensure the end date is always greater or equal to the start date
            if (dtpEndDate.Value < dtpStartDate.Value)
            {
                dtpEndDate.Value = dtpStartDate.Value.AddMinutes(1);
            }
            dtpEndDate.MinDate = dtpStartDate.Value;
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            // Ensure the start date is always less or equal to the end date
            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                dtpStartDate.Value = dtpEndDate.Value;
            }
        }

        private bool IsValidData()
        {
            // Checking all relevant information to make sure it is present and validated
            // Event Name must be present and at least 10 characters
            // Venue Address must be present and within 30 characters
            // Venue Capacity must be present and between the int 5 and 1000
            // Event Description must be present and at least 10 characters
            // Start Date must be within 2 years from today.

            return
                Validator.IsPresent(tbxName) &&
                Validator.IsLength(tbxName, 20) &&
                Validator.IsPresent(tbxAddress) &&
                Validator.IsLength(tbxAddress, 120) &&
                Validator.IsPresent(tbxCapacity) &&
                Validator.IsWithinRange(tbxCapacity, 5,1000) &&
                Validator.IsPresent(tbxDescription) &&
                Validator.IsLength(tbxDescription, 500) &&
                Validator.IsWithinRange(dtpStartDate, DateTime.Today, (DateTime.Today.AddYears(2)));

        }

        private void cbxVenueSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

            string eventName = cbxVenueSelect.Text.Trim();
            //selectedEvent = context.Events.Find(eventName);
            if(!cbxVenueSelect.Equals("") || !(cbxVenueSelect == null))
            {
                using (OMScontext context = new OMScontext())
                {
                    var data = from venueRecord in context.Venues
                               where venueRecord.Name.Equals(cbxVenueSelect.Text)
                               select new
                               {
                                   Name = venueRecord.Name,
                                   Address = venueRecord.Address,
                                   Capacity = venueRecord.Capacity
                               };
                    if (data.ToList() != null)
                    {
                        tbxAddress.Text = data.ToList().Find(p => p.Name.Equals(cbxVenueSelect.Text)).Address;
                        tbxCapacity.Text = data.ToList().Find(p => p.Name.Equals(cbxVenueSelect.Text)).Capacity.ToString();
                        // If it finds a match, disable creating venue as well as editing the current ones.
                        tbxAddress.Enabled = false;
                        tbxCapacity.Enabled = false;
                        btnAddVenue.Visible = false;
                    }
                    else
                    {
                        tbxAddress.Text = "";
                        tbxCapacity.Text = "";

                    }
                }

            }
            else
            {

            }



        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.DialogResult = DialogResult.Cancel;
        }

        private void UpdateComboBox()
        {
            cbxVenueSelect.Items.Clear();
            cbxEventCat.Items.Clear();

            foreach (Venues iterateVenues in _OMScontext.Venues.ToList())
            {
                // If the company owns the venue, display it.
                // If not, do not display it. 
                if(iterateVenues.CompanyOwned)
                    cbxVenueSelect.Items.Add(iterateVenues.Name);
            }

            foreach (EventCategories iterateCategories in _OMScontext.EventCategories.ToList())
            {
                cbxEventCat.Items.Add(iterateCategories.Name);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            using (OMScontext context = new OMScontext())
            {
                if (currentEvent != null)
                {
                    // Have the event we are currently editing
                    // We could check to see if anything has changed. If it has, we can edit the current event to match
                    // We could also just save everything from the screen into the current event, without detecting a change.
                    if (!IsValidData())
                        return;

                    DialogResult result = MessageBox.Show("Would you like to save this event change?", "Edit Event", MessageBoxButtons.YesNoCancel);

                    if (result == DialogResult.Cancel)
                    {
                        // If they cancel, it will reset the form back to the original event
                        tbxName.Text = currentEvent.Name;
                        dtpStartDate.Value = currentEvent.StartDate;
                        dtpEndDate.Value = currentEvent.EndDate;
                        tbxDescription.Text = currentEvent.Description;

                        Venues venue = context.Venues
                        .Where(item => item.ID == currentEvent.VenuesID)
                        .FirstOrDefault();
                        cbxVenueSelect.SelectedIndex = cbxVenueSelect.Items.IndexOf(venue.Name);


                        EventCategories eventCat = context.EventCategories
                            .Where(item => item.ID == currentEvent.CategoryID)
                            .FirstOrDefault();
                        cbxEventCat.SelectedIndex = cbxEventCat.Items.IndexOf(eventCat.Name);

                    } else if (result == DialogResult.No)
                    {
                        // If they say No, do nothing, leave the form as is and leave the event
                    } else if (result == DialogResult.Yes)
                    {
                        // If they say Yes, we take the changes and apply them to the associated record through currentEvent.
                        // We retrieve the event to be modified
                        var eventToModify = context.Events.FirstOrDefault(p => p.ID == currentEvent.ID);

                        // Take what is in the textboxes
                        eventToModify.Name = tbxName.Text;
                        eventToModify.StartDate = dtpStartDate.Value;
                        eventToModify.EndDate = dtpEndDate.Value;
                        eventToModify.Description = tbxDescription.Text;

                        // Find associated records based on the text of the comboboxes
                        Debug.WriteLine("cbxVenueSelect.Text: " + cbxVenueSelect.Text);
                        Venues venue = context.Venues
                            .Where(item => item.Name == cbxVenueSelect.Text)
                            .FirstOrDefault();
                        eventToModify.VenuesID = venue.ID;


                        Debug.WriteLine("cbxEventCat.Text: " + cbxEventCat.Text);
                        EventCategories eventCat = context.EventCategories
                            .Where(item => item.Name == cbxEventCat.Text)
                            .FirstOrDefault();
                        eventToModify.CategoryID = eventCat.ID;

                        // Finally, we save the changes that we made to the eventToModify.
                        context.SaveChanges();

                    }


                }

            }
        }

        private void cbxVenueSelect_TextUpdate(object sender, EventArgs e)
        {
            btnAddVenue.Visible = true;
            tbxAddress.Enabled = true;
            tbxCapacity.Enabled = true;
        }

        private void btnAddVenue_Click(object sender, EventArgs e)
        {
            using(OMScontext context = new OMScontext())
            {
                DialogResult result = MessageBox.Show("Are you sure you wish to add this venue to available Venues?", "Add to available venues?", MessageBoxButtons.YesNo);

                var existingVenue = context.Venues.FirstOrDefault(p => p.Name.Equals(cbxVenueSelect.Text));
                if((existingVenue != null))
                {
                    // Kicks out if the Venue table already has something with the same name. 
                    MessageBox.Show("Venue with the same name already Exists");
                    return;
                }

                if(IsVenueValidData() && (result == DialogResult.Yes))
                {
                    // Needs to check if the Venue already exists
                    Venues addVenue = new Venues();
                    addVenue.Address = tbxAddress.Text;
                    addVenue.Capacity = Convert.ToInt32(tbxCapacity.Text);
                    addVenue.Name = cbxVenueSelect.Text;
                    addVenue.CompanyOwned = false;

                    context.Venues.Add(addVenue);
                    context.SaveChanges();
                }

            }
           
        }

        private Boolean IsVenueValidData()
        {
            return
                Validator.IsPresent(tbxAddress) &&
                Validator.IsLength(tbxAddress, 120) &&
                Validator.IsPresent(tbxCapacity) &&
                Validator.IsWithinRange(tbxCapacity, 5, 1000);
            //throw new NotImplementedException();
        }

        private void addVenueImage()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                venueImage = new Bitmap(openFileDialog1.FileName);
                pbxVenue.Image = venueImage;
            }
        }

        private void btnVenuePic_Click(object sender, EventArgs e)
        {
            addVenueImage();
        }
    }
}
