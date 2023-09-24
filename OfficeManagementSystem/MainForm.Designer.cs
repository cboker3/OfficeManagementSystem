namespace OfficeManagementSystem
{
    partial class MainForm
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
            this.menuEMS = new System.Windows.Forms.MenuStrip();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.venuesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createEventToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.eventRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventResourcesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.taskTrackingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messagingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.teamMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactMessagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venuesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venueInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.venueSchedulingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.debugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.dgvExtra = new System.Windows.Forms.DataGridView();
            this.cbxExtra = new System.Windows.Forms.ComboBox();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lblPages = new System.Windows.Forms.Label();
            this.btnGoTo = new System.Windows.Forms.Button();
            this.tbxPage = new System.Windows.Forms.TextBox();
            this.tbxEPage = new System.Windows.Forms.TextBox();
            this.btnEGoTo = new System.Windows.Forms.Button();
            this.lblEPages = new System.Windows.Forms.Label();
            this.btnELast = new System.Windows.Forms.Button();
            this.btnENext = new System.Windows.Forms.Button();
            this.btnEPrev = new System.Windows.Forms.Button();
            this.btnEFirst = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.menuEMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtra)).BeginInit();
            this.SuspendLayout();
            // 
            // menuEMS
            // 
            this.menuEMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.eventsToolStripMenuItem,
            this.tasksToolStripMenuItem,
            this.messagingToolStripMenuItem,
            this.venuesToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.debugToolStripMenuItem});
            this.menuEMS.Location = new System.Drawing.Point(0, 0);
            this.menuEMS.Name = "menuEMS";
            this.menuEMS.Size = new System.Drawing.Size(824, 24);
            this.menuEMS.TabIndex = 0;
            this.menuEMS.Text = "menuEMSstrip";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userLoginToolStripMenuItem,
            this.createUserToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            // 
            // userLoginToolStripMenuItem
            // 
            this.userLoginToolStripMenuItem.Name = "userLoginToolStripMenuItem";
            this.userLoginToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.userLoginToolStripMenuItem.Text = "User Login";
            this.userLoginToolStripMenuItem.Click += new System.EventHandler(this.userLoginToolStripMenuItem_Click);
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.createUserToolStripMenuItem.Text = "Create User";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventsToolStripMenuItem1,
            this.tasksToolStripMenuItem1,
            this.venuesToolStripMenuItem1,
            this.contactsToolStripMenuItem,
            this.resourcesToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // eventsToolStripMenuItem1
            // 
            this.eventsToolStripMenuItem1.Name = "eventsToolStripMenuItem1";
            this.eventsToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.eventsToolStripMenuItem1.Text = "Events";
            // 
            // tasksToolStripMenuItem1
            // 
            this.tasksToolStripMenuItem1.Name = "tasksToolStripMenuItem1";
            this.tasksToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.tasksToolStripMenuItem1.Text = "Tasks";
            this.tasksToolStripMenuItem1.Click += new System.EventHandler(this.tasksToolStripMenuItem1_Click);
            // 
            // venuesToolStripMenuItem1
            // 
            this.venuesToolStripMenuItem1.Name = "venuesToolStripMenuItem1";
            this.venuesToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.venuesToolStripMenuItem1.Text = "Venues";
            this.venuesToolStripMenuItem1.Click += new System.EventHandler(this.venuesToolStripMenuItem1_Click);
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.contactsToolStripMenuItem.Text = "Contacts";
            this.contactsToolStripMenuItem.Click += new System.EventHandler(this.contactsToolStripMenuItem_Click);
            // 
            // resourcesToolStripMenuItem
            // 
            this.resourcesToolStripMenuItem.Name = "resourcesToolStripMenuItem";
            this.resourcesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.resourcesToolStripMenuItem.Text = "Resources";
            this.resourcesToolStripMenuItem.Click += new System.EventHandler(this.resourcesToolStripMenuItem_Click);
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createEventToolStripMenuItem,
            this.toolStripSeparator2,
            this.eventRegistrationToolStripMenuItem,
            this.eventResourcesToolStripMenuItem});
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.eventsToolStripMenuItem.Text = "Events";
            // 
            // createEventToolStripMenuItem
            // 
            this.createEventToolStripMenuItem.Name = "createEventToolStripMenuItem";
            this.createEventToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.createEventToolStripMenuItem.Text = "Create Event";
            this.createEventToolStripMenuItem.Click += new System.EventHandler(this.createEventToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(166, 6);
            // 
            // eventRegistrationToolStripMenuItem
            // 
            this.eventRegistrationToolStripMenuItem.Name = "eventRegistrationToolStripMenuItem";
            this.eventRegistrationToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.eventRegistrationToolStripMenuItem.Text = "Event Registration";
            // 
            // eventResourcesToolStripMenuItem
            // 
            this.eventResourcesToolStripMenuItem.Name = "eventResourcesToolStripMenuItem";
            this.eventResourcesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.eventResourcesToolStripMenuItem.Text = "Event Resources";
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTaskToolStripMenuItem,
            this.toolStripSeparator1,
            this.taskTrackingToolStripMenuItem});
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.tasksToolStripMenuItem.Text = "Tasks";
            // 
            // createTaskToolStripMenuItem
            // 
            this.createTaskToolStripMenuItem.Name = "createTaskToolStripMenuItem";
            this.createTaskToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.createTaskToolStripMenuItem.Text = "Create Task";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(140, 6);
            // 
            // taskTrackingToolStripMenuItem
            // 
            this.taskTrackingToolStripMenuItem.Name = "taskTrackingToolStripMenuItem";
            this.taskTrackingToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.taskTrackingToolStripMenuItem.Text = "Task Tracking";
            // 
            // messagingToolStripMenuItem
            // 
            this.messagingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamMessagesToolStripMenuItem,
            this.contactMessagesToolStripMenuItem});
            this.messagingToolStripMenuItem.Name = "messagingToolStripMenuItem";
            this.messagingToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.messagingToolStripMenuItem.Text = "Messaging";
            // 
            // teamMessagesToolStripMenuItem
            // 
            this.teamMessagesToolStripMenuItem.Name = "teamMessagesToolStripMenuItem";
            this.teamMessagesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.teamMessagesToolStripMenuItem.Text = "Team Messages";
            // 
            // contactMessagesToolStripMenuItem
            // 
            this.contactMessagesToolStripMenuItem.Name = "contactMessagesToolStripMenuItem";
            this.contactMessagesToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.contactMessagesToolStripMenuItem.Text = "Contact Messages";
            // 
            // venuesToolStripMenuItem
            // 
            this.venuesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.venueInformationToolStripMenuItem,
            this.venueSchedulingToolStripMenuItem});
            this.venuesToolStripMenuItem.Name = "venuesToolStripMenuItem";
            this.venuesToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.venuesToolStripMenuItem.Text = "Venues";
            // 
            // venueInformationToolStripMenuItem
            // 
            this.venueInformationToolStripMenuItem.Name = "venueInformationToolStripMenuItem";
            this.venueInformationToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.venueInformationToolStripMenuItem.Text = "Venue Information";
            // 
            // venueSchedulingToolStripMenuItem
            // 
            this.venueSchedulingToolStripMenuItem.Name = "venueSchedulingToolStripMenuItem";
            this.venueSchedulingToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.venueSchedulingToolStripMenuItem.Text = "Venue Scheduling";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateReportsToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // generateReportsToolStripMenuItem
            // 
            this.generateReportsToolStripMenuItem.Name = "generateReportsToolStripMenuItem";
            this.generateReportsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.generateReportsToolStripMenuItem.Text = "Generate Reports";
            // 
            // debugToolStripMenuItem
            // 
            this.debugToolStripMenuItem.Name = "debugToolStripMenuItem";
            this.debugToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.debugToolStripMenuItem.Text = "Debug";
            this.debugToolStripMenuItem.Visible = false;
            this.debugToolStripMenuItem.Click += new System.EventHandler(this.debugToolStripMenuItem_Click);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeColumns = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Location = new System.Drawing.Point(12, 97);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.Size = new System.Drawing.Size(800, 310);
            this.dgvMain.TabIndex = 1;
            this.dgvMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellContentClick_1);
            this.dgvMain.SelectionChanged += new System.EventHandler(this.dgvMain_SelectionChanged);
            // 
            // dgvExtra
            // 
            this.dgvExtra.AllowUserToAddRows = false;
            this.dgvExtra.AllowUserToDeleteRows = false;
            this.dgvExtra.AllowUserToResizeColumns = false;
            this.dgvExtra.AllowUserToResizeRows = false;
            this.dgvExtra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExtra.Cursor = System.Windows.Forms.Cursors.Default;
            this.dgvExtra.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvExtra.Location = new System.Drawing.Point(12, 440);
            this.dgvExtra.MultiSelect = false;
            this.dgvExtra.Name = "dgvExtra";
            this.dgvExtra.ReadOnly = true;
            this.dgvExtra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExtra.Size = new System.Drawing.Size(800, 287);
            this.dgvExtra.TabIndex = 2;
            this.dgvExtra.DataSourceChanged += new System.EventHandler(this.dgvExtra_DataSourceChanged);
            this.dgvExtra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExtra_CellContentClick);
            this.dgvExtra.SelectionChanged += new System.EventHandler(this.dgvExtra_SelectionChanged);
            // 
            // cbxExtra
            // 
            this.cbxExtra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxExtra.FormattingEnabled = true;
            this.cbxExtra.Location = new System.Drawing.Point(626, 413);
            this.cbxExtra.Name = "cbxExtra";
            this.cbxExtra.Size = new System.Drawing.Size(186, 21);
            this.cbxExtra.TabIndex = 3;
            this.cbxExtra.SelectedIndexChanged += new System.EventHandler(this.cbxExtra_SelectedIndexChanged);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(12, 411);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(75, 25);
            this.btnFirst.TabIndex = 4;
            this.btnFirst.Text = "<<";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Location = new System.Drawing.Point(93, 411);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(75, 25);
            this.btnPrev.TabIndex = 5;
            this.btnPrev.Text = "<";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(174, 411);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 25);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = ">";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(255, 411);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(75, 25);
            this.btnLast.TabIndex = 7;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(452, 417);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(12, 13);
            this.lblPages.TabIndex = 8;
            this.lblPages.Text = "/";
            // 
            // btnGoTo
            // 
            this.btnGoTo.Location = new System.Drawing.Point(500, 413);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(75, 23);
            this.btnGoTo.TabIndex = 9;
            this.btnGoTo.Text = "Go To Page";
            this.btnGoTo.UseVisualStyleBackColor = true;
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);
            // 
            // tbxPage
            // 
            this.tbxPage.Location = new System.Drawing.Point(394, 413);
            this.tbxPage.Name = "tbxPage";
            this.tbxPage.Size = new System.Drawing.Size(52, 20);
            this.tbxPage.TabIndex = 10;
            // 
            // tbxEPage
            // 
            this.tbxEPage.Location = new System.Drawing.Point(394, 735);
            this.tbxEPage.Name = "tbxEPage";
            this.tbxEPage.Size = new System.Drawing.Size(52, 20);
            this.tbxEPage.TabIndex = 17;
            // 
            // btnEGoTo
            // 
            this.btnEGoTo.Location = new System.Drawing.Point(500, 735);
            this.btnEGoTo.Name = "btnEGoTo";
            this.btnEGoTo.Size = new System.Drawing.Size(75, 23);
            this.btnEGoTo.TabIndex = 16;
            this.btnEGoTo.Text = "Go To Page";
            this.btnEGoTo.UseVisualStyleBackColor = true;
            // 
            // lblEPages
            // 
            this.lblEPages.AutoSize = true;
            this.lblEPages.Location = new System.Drawing.Point(452, 739);
            this.lblEPages.Name = "lblEPages";
            this.lblEPages.Size = new System.Drawing.Size(12, 13);
            this.lblEPages.TabIndex = 15;
            this.lblEPages.Text = "/";
            // 
            // btnELast
            // 
            this.btnELast.Location = new System.Drawing.Point(255, 733);
            this.btnELast.Name = "btnELast";
            this.btnELast.Size = new System.Drawing.Size(75, 25);
            this.btnELast.TabIndex = 14;
            this.btnELast.Text = ">>";
            this.btnELast.UseVisualStyleBackColor = true;
            // 
            // btnENext
            // 
            this.btnENext.Location = new System.Drawing.Point(174, 733);
            this.btnENext.Name = "btnENext";
            this.btnENext.Size = new System.Drawing.Size(75, 25);
            this.btnENext.TabIndex = 13;
            this.btnENext.Text = ">";
            this.btnENext.UseVisualStyleBackColor = true;
            // 
            // btnEPrev
            // 
            this.btnEPrev.Location = new System.Drawing.Point(93, 733);
            this.btnEPrev.Name = "btnEPrev";
            this.btnEPrev.Size = new System.Drawing.Size(75, 25);
            this.btnEPrev.TabIndex = 12;
            this.btnEPrev.Text = "<";
            this.btnEPrev.UseVisualStyleBackColor = true;
            // 
            // btnEFirst
            // 
            this.btnEFirst.Location = new System.Drawing.Point(12, 733);
            this.btnEFirst.Name = "btnEFirst";
            this.btnEFirst.Size = new System.Drawing.Size(75, 25);
            this.btnEFirst.TabIndex = 11;
            this.btnEFirst.Text = "<<";
            this.btnEFirst.UseVisualStyleBackColor = true;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(737, 735);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 18;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 769);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.tbxEPage);
            this.Controls.Add(this.btnEGoTo);
            this.Controls.Add(this.lblEPages);
            this.Controls.Add(this.btnELast);
            this.Controls.Add(this.btnENext);
            this.Controls.Add(this.btnEPrev);
            this.Controls.Add(this.btnEFirst);
            this.Controls.Add(this.tbxPage);
            this.Controls.Add(this.btnGoTo);
            this.Controls.Add(this.lblPages);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.cbxExtra);
            this.Controls.Add(this.dgvExtra);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.menuEMS);
            this.MainMenuStrip = this.menuEMS;
            this.Name = "MainForm";
            this.Text = "Event Managment System";
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.menuEMS.ResumeLayout(false);
            this.menuEMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExtra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuEMS;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createEventToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem eventRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventResourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem messagingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem teamMessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactMessagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venuesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venueInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem debugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taskTrackingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem venueSchedulingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem venuesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resourcesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridView dgvExtra;
        private System.Windows.Forms.ComboBox cbxExtra;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.Button btnGoTo;
        private System.Windows.Forms.TextBox tbxPage;
        private System.Windows.Forms.TextBox tbxEPage;
        private System.Windows.Forms.Button btnEGoTo;
        private System.Windows.Forms.Label lblEPages;
        private System.Windows.Forms.Button btnELast;
        private System.Windows.Forms.Button btnENext;
        private System.Windows.Forms.Button btnEPrev;
        private System.Windows.Forms.Button btnEFirst;
        private System.Windows.Forms.Button btnModify;
    }
}