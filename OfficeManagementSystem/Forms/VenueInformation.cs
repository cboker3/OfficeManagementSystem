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
    public partial class VenueInformation : Form
    {
        OMScontext _OMScontext = new OMScontext();
        Users currentUser;

        public VenueInformation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                layoutDiagramPictureBox.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void VenueInformation_Load(object sender, EventArgs e)
        {
            //venuesBindingSource. = new OMScontext();
            //venuesBindingSource.DataSource = _OMScontext.Venues.ToList();


            // I don't understand this. 
            _OMScontext.Venues.Load();
            venuesBindingSource.DataSource = _OMScontext.Venues.Local.ToBindingList();


        }

        public void displayVenueInformation(Users localUser)
        {
            currentUser = localUser;
            this.Show();

        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            venuesBindingSource.EndEdit();
            _OMScontext.SaveChanges();
        }
    }
}
