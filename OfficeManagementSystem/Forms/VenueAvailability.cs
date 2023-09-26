﻿using System;
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

namespace OfficeManagementSystem.Forms
{
    public partial class VenueAvailability : Form
    {
        OMScontext dbContext = new OMScontext();

        Users user;

        public VenueAvailability()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if the CheckBox is currently checked
            if (checkBox1.Checked)
            {
                // If it's checked, uncheck it
                checkBox1.Checked = false;
            }
            else
            {
                // If it's not checked, check it
                checkBox1.Checked = true;
            }
        }

        private void VenueAvailability_Load(object sender, EventArgs e)
        {
            if (isAdmin())
            {
                // If the user is an admin, make the button visible
                adminButton.Visible = true;
            }
            else
            {
                // If the user is not an admin, hide the button
                adminButton.Visible = false;
            }
        }

        private bool isAdmin()
        {
            return (user.Role.Equals("Admin"));
            throw new NotImplementedException();
        }

        public void displayVenueAvailability(Users login)
        {
            user = login;

            this.Show();
        }


        // Need to get all events for a specific venue
        // Then create an array of dates when they are being used
        // Then create an inverse of this array to display when they can be used.
        // Research DateTime information, and maybe a datetimepicker validation.
    }
}
