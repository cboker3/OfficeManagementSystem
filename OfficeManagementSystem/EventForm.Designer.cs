namespace OfficeManagementSystem
{
    partial class EventForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbVenue = new System.Windows.Forms.GroupBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.cbxVenueSelect = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.tbxDescription = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblEventCat = new System.Windows.Forms.Label();
            this.cbxEventCat = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxCapacity = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.gpbVenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbVenue
            // 
            this.gpbVenue.Controls.Add(this.tbxCapacity);
            this.gpbVenue.Controls.Add(this.tbxAddress);
            this.gpbVenue.Controls.Add(this.lblAddress);
            this.gpbVenue.Controls.Add(this.lblCapacity);
            this.gpbVenue.Controls.Add(this.cbxVenueSelect);
            this.gpbVenue.Location = new System.Drawing.Point(274, 12);
            this.gpbVenue.Name = "gpbVenue";
            this.gpbVenue.Size = new System.Drawing.Size(329, 164);
            this.gpbVenue.TabIndex = 0;
            this.gpbVenue.TabStop = false;
            this.gpbVenue.Text = "Venue";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Location = new System.Drawing.Point(6, 105);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(51, 13);
            this.lblCapacity.TabIndex = 2;
            this.lblCapacity.Text = "Capacity:";
            // 
            // cbxVenueSelect
            // 
            this.cbxVenueSelect.FormattingEnabled = true;
            this.cbxVenueSelect.Location = new System.Drawing.Point(6, 19);
            this.cbxVenueSelect.Name = "cbxVenueSelect";
            this.cbxVenueSelect.Size = new System.Drawing.Size(146, 21);
            this.cbxVenueSelect.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 13);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(102, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name of the Event: ";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(120, 10);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(145, 20);
            this.tbxName.TabIndex = 2;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(12, 67);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(124, 13);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description of the Event:";
            // 
            // tbxDescription
            // 
            this.tbxDescription.Location = new System.Drawing.Point(15, 83);
            this.tbxDescription.Multiline = true;
            this.tbxDescription.Name = "tbxDescription";
            this.tbxDescription.Size = new System.Drawing.Size(253, 93);
            this.tbxDescription.TabIndex = 4;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(76, 186);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 5;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(15, 186);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 6;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(15, 216);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(55, 13);
            this.lblEndDate.TabIndex = 8;
            this.lblEndDate.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(76, 216);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 7;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(428, 219);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(528, 219);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblEventCat
            // 
            this.lblEventCat.AutoSize = true;
            this.lblEventCat.Location = new System.Drawing.Point(12, 42);
            this.lblEventCat.Name = "lblEventCat";
            this.lblEventCat.Size = new System.Drawing.Size(95, 13);
            this.lblEventCat.TabIndex = 11;
            this.lblEventCat.Text = "Category of Event:";
            // 
            // cbxEventCat
            // 
            this.cbxEventCat.FormattingEnabled = true;
            this.cbxEventCat.Location = new System.Drawing.Point(120, 39);
            this.cbxEventCat.Name = "cbxEventCat";
            this.cbxEventCat.Size = new System.Drawing.Size(145, 21);
            this.cbxEventCat.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(6, 55);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address:";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(6, 71);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(146, 20);
            this.tbxAddress.TabIndex = 4;
            // 
            // tbxCapacity
            // 
            this.tbxCapacity.Location = new System.Drawing.Point(6, 121);
            this.tbxCapacity.Name = "tbxCapacity";
            this.tbxCapacity.Size = new System.Drawing.Size(146, 20);
            this.tbxCapacity.TabIndex = 5;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(328, 219);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 259);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbxEventCat);
            this.Controls.Add(this.lblEventCat);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.tbxDescription);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.gpbVenue);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.gpbVenue.ResumeLayout(false);
            this.gpbVenue.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbVenue;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.ComboBox cbxVenueSelect;
        private System.Windows.Forms.TextBox tbxDescription;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblEventCat;
        private System.Windows.Forms.ComboBox cbxEventCat;
        private System.Windows.Forms.TextBox tbxCapacity;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Button btnEdit;
    }
}