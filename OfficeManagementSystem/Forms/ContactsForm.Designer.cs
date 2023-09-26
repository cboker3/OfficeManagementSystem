namespace OfficeManagementSystem.Forms
{
    partial class ContactsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label organizationLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsForm));
            this.messagesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.messagesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDLabel1 = new System.Windows.Forms.Label();
            this.firstNameComboBox = new System.Windows.Forms.ComboBox();
            this.lastNameComboBox = new System.Windows.Forms.ComboBox();
            this.organizationComboBox = new System.Windows.Forms.ComboBox();
            this.phoneComboBox = new System.Windows.Forms.ComboBox();
            this.emailComboBox = new System.Windows.Forms.ComboBox();
            this.contactsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.messagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iDLabel = new System.Windows.Forms.Label();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            organizationLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingNavigator)).BeginInit();
            this.messagesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(23, 35);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new System.Drawing.Point(20, 64);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(60, 13);
            firstNameLabel.TabIndex = 3;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(19, 91);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(61, 13);
            lastNameLabel.TabIndex = 5;
            lastNameLabel.Text = "Last Name:";
            // 
            // organizationLabel
            // 
            organizationLabel.AutoSize = true;
            organizationLabel.Location = new System.Drawing.Point(11, 118);
            organizationLabel.Name = "organizationLabel";
            organizationLabel.Size = new System.Drawing.Size(69, 13);
            organizationLabel.TabIndex = 7;
            organizationLabel.Text = "Organization:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(39, 145);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "Phone:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(45, 172);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(35, 13);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "Email:";
            // 
            // messagesBindingNavigator
            // 
            this.messagesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.messagesBindingNavigator.BindingSource = this.messagesBindingSource;
            this.messagesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.messagesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.messagesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.messagesBindingNavigatorSaveItem});
            this.messagesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.messagesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.messagesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.messagesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.messagesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.messagesBindingNavigator.Name = "messagesBindingNavigator";
            this.messagesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.messagesBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.messagesBindingNavigator.TabIndex = 0;
            this.messagesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // messagesBindingNavigatorSaveItem
            // 
            this.messagesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.messagesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("messagesBindingNavigatorSaveItem.Image")));
            this.messagesBindingNavigatorSaveItem.Name = "messagesBindingNavigatorSaveItem";
            this.messagesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.messagesBindingNavigatorSaveItem.Text = "Save Data";
            this.messagesBindingNavigatorSaveItem.Click += new System.EventHandler(this.messagesBindingNavigatorSaveItem_Click);
            // 
            // iDLabel1
            // 
            this.iDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "ID", true));
            this.iDLabel1.Location = new System.Drawing.Point(50, 35);
            this.iDLabel1.Name = "iDLabel1";
            this.iDLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDLabel1.TabIndex = 2;
            this.iDLabel1.Text = "label1";
            // 
            // firstNameComboBox
            // 
            this.firstNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "FirstName", true));
            this.firstNameComboBox.FormattingEnabled = true;
            this.firstNameComboBox.Location = new System.Drawing.Point(86, 61);
            this.firstNameComboBox.Name = "firstNameComboBox";
            this.firstNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.firstNameComboBox.TabIndex = 4;
            // 
            // lastNameComboBox
            // 
            this.lastNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "LastName", true));
            this.lastNameComboBox.FormattingEnabled = true;
            this.lastNameComboBox.Location = new System.Drawing.Point(86, 88);
            this.lastNameComboBox.Name = "lastNameComboBox";
            this.lastNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.lastNameComboBox.TabIndex = 6;
            // 
            // organizationComboBox
            // 
            this.organizationComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Organization", true));
            this.organizationComboBox.FormattingEnabled = true;
            this.organizationComboBox.Location = new System.Drawing.Point(86, 115);
            this.organizationComboBox.Name = "organizationComboBox";
            this.organizationComboBox.Size = new System.Drawing.Size(121, 21);
            this.organizationComboBox.TabIndex = 8;
            // 
            // phoneComboBox
            // 
            this.phoneComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Phone", true));
            this.phoneComboBox.FormattingEnabled = true;
            this.phoneComboBox.Location = new System.Drawing.Point(86, 142);
            this.phoneComboBox.Name = "phoneComboBox";
            this.phoneComboBox.Size = new System.Drawing.Size(121, 21);
            this.phoneComboBox.TabIndex = 10;
            // 
            // emailComboBox
            // 
            this.emailComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactsBindingSource, "Email", true));
            this.emailComboBox.FormattingEnabled = true;
            this.emailComboBox.Location = new System.Drawing.Point(86, 169);
            this.emailComboBox.Name = "emailComboBox";
            this.emailComboBox.Size = new System.Drawing.Size(121, 21);
            this.emailComboBox.TabIndex = 12;
            // 
            // contactsBindingSource
            // 
            this.contactsBindingSource.DataSource = typeof(OfficeManagementSystem.Models.Contacts);
            // 
            // messagesBindingSource
            // 
            this.messagesBindingSource.DataSource = typeof(OfficeManagementSystem.Models.Messages);
            // 
            // ContactsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailComboBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneComboBox);
            this.Controls.Add(organizationLabel);
            this.Controls.Add(this.organizationComboBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameComboBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameComboBox);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDLabel1);
            this.Controls.Add(this.messagesBindingNavigator);
            this.Name = "ContactsForm";
            this.Text = "ContactsForm1";
            this.Load += new System.EventHandler(this.ContactsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingNavigator)).EndInit();
            this.messagesBindingNavigator.ResumeLayout(false);
            this.messagesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contactsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource messagesBindingSource;
        private System.Windows.Forms.BindingNavigator messagesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton messagesBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingSource contactsBindingSource;
        private System.Windows.Forms.Label iDLabel1;
        private System.Windows.Forms.ComboBox firstNameComboBox;
        private System.Windows.Forms.ComboBox lastNameComboBox;
        private System.Windows.Forms.ComboBox organizationComboBox;
        private System.Windows.Forms.ComboBox phoneComboBox;
        private System.Windows.Forms.ComboBox emailComboBox;
    }
}