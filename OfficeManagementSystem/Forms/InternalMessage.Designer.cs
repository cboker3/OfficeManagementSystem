namespace OfficeManagementSystem.Forms
{
    partial class InternalMessage
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
            System.Windows.Forms.Label receiverIDLabel;
            System.Windows.Forms.Label senderIDLabel;
            System.Windows.Forms.Label subjectLabel;
            System.Windows.Forms.Label contentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InternalMessage));
            System.Windows.Forms.Label timestampLabel;
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
            this.receiverIDLabel1 = new System.Windows.Forms.Label();
            this.senderIDLabel1 = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.contentTextBox = new System.Windows.Forms.TextBox();
            this.messagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timestampDateTimePicker = new System.Windows.Forms.DateTimePicker();
            iDLabel = new System.Windows.Forms.Label();
            receiverIDLabel = new System.Windows.Forms.Label();
            senderIDLabel = new System.Windows.Forms.Label();
            subjectLabel = new System.Windows.Forms.Label();
            contentLabel = new System.Windows.Forms.Label();
            timestampLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingNavigator)).BeginInit();
            this.messagesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(11, 25);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // receiverIDLabel
            // 
            receiverIDLabel.AutoSize = true;
            receiverIDLabel.Location = new System.Drawing.Point(127, 25);
            receiverIDLabel.Name = "receiverIDLabel";
            receiverIDLabel.Size = new System.Drawing.Size(67, 13);
            receiverIDLabel.TabIndex = 3;
            receiverIDLabel.Text = "Receiver ID:";
            // 
            // senderIDLabel
            // 
            senderIDLabel.AutoSize = true;
            senderIDLabel.Location = new System.Drawing.Point(262, 25);
            senderIDLabel.Name = "senderIDLabel";
            senderIDLabel.Size = new System.Drawing.Size(58, 13);
            senderIDLabel.TabIndex = 5;
            senderIDLabel.Text = "Sender ID:";
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Location = new System.Drawing.Point(13, 82);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new System.Drawing.Size(46, 13);
            subjectLabel.TabIndex = 7;
            subjectLabel.Text = "Subject:";
            // 
            // contentLabel
            // 
            contentLabel.AutoSize = true;
            contentLabel.Location = new System.Drawing.Point(12, 126);
            contentLabel.Name = "contentLabel";
            contentLabel.Size = new System.Drawing.Size(47, 13);
            contentLabel.TabIndex = 9;
            contentLabel.Text = "Content:";
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
            this.messagesBindingNavigator.Size = new System.Drawing.Size(820, 25);
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
            this.messagesBindingNavigatorSaveItem.Enabled = false;
            this.messagesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("messagesBindingNavigatorSaveItem.Image")));
            this.messagesBindingNavigatorSaveItem.Name = "messagesBindingNavigatorSaveItem";
            this.messagesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.messagesBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // iDLabel1
            // 
            this.iDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messagesBindingSource, "ID", true));
            this.iDLabel1.Location = new System.Drawing.Point(38, 25);
            this.iDLabel1.Name = "iDLabel1";
            this.iDLabel1.Size = new System.Drawing.Size(100, 23);
            this.iDLabel1.TabIndex = 2;
            this.iDLabel1.Text = "label1";
            // 
            // receiverIDLabel1
            // 
            this.receiverIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messagesBindingSource, "ReceiverID", true));
            this.receiverIDLabel1.Location = new System.Drawing.Point(200, 25);
            this.receiverIDLabel1.Name = "receiverIDLabel1";
            this.receiverIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.receiverIDLabel1.TabIndex = 4;
            this.receiverIDLabel1.Text = "label1";
            // 
            // senderIDLabel1
            // 
            this.senderIDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messagesBindingSource, "SenderID", true));
            this.senderIDLabel1.Location = new System.Drawing.Point(326, 25);
            this.senderIDLabel1.Name = "senderIDLabel1";
            this.senderIDLabel1.Size = new System.Drawing.Size(100, 23);
            this.senderIDLabel1.TabIndex = 6;
            this.senderIDLabel1.Text = "label1";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messagesBindingSource, "Subject", true));
            this.subjectTextBox.Location = new System.Drawing.Point(65, 79);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(183, 20);
            this.subjectTextBox.TabIndex = 8;
            // 
            // contentTextBox
            // 
            this.contentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.messagesBindingSource, "Content", true));
            this.contentTextBox.Location = new System.Drawing.Point(65, 123);
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.Size = new System.Drawing.Size(293, 145);
            this.contentTextBox.TabIndex = 10;
            // 
            // messagesBindingSource
            // 
            this.messagesBindingSource.DataSource = typeof(OfficeManagementSystem.Models.Messages);
            // 
            // timestampLabel
            // 
            timestampLabel.AutoSize = true;
            timestampLabel.Location = new System.Drawing.Point(262, 82);
            timestampLabel.Name = "timestampLabel";
            timestampLabel.Size = new System.Drawing.Size(61, 13);
            timestampLabel.TabIndex = 11;
            timestampLabel.Text = "Timestamp:";
            // 
            // timestampDateTimePicker
            // 
            this.timestampDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.messagesBindingSource, "Timestamp", true));
            this.timestampDateTimePicker.Location = new System.Drawing.Point(329, 78);
            this.timestampDateTimePicker.Name = "timestampDateTimePicker";
            this.timestampDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.timestampDateTimePicker.TabIndex = 12;
            // 
            // InternalMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 450);
            this.Controls.Add(timestampLabel);
            this.Controls.Add(this.timestampDateTimePicker);
            this.Controls.Add(contentLabel);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(subjectLabel);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(senderIDLabel);
            this.Controls.Add(this.senderIDLabel1);
            this.Controls.Add(receiverIDLabel);
            this.Controls.Add(this.receiverIDLabel1);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDLabel1);
            this.Controls.Add(this.messagesBindingNavigator);
            this.Name = "InternalMessage";
            this.Text = "Messages";
            this.Load += new System.EventHandler(this.InternalMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messagesBindingNavigator)).EndInit();
            this.messagesBindingNavigator.ResumeLayout(false);
            this.messagesBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.Label iDLabel1;
        private System.Windows.Forms.Label receiverIDLabel1;
        private System.Windows.Forms.Label senderIDLabel1;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox contentTextBox;
        private System.Windows.Forms.DateTimePicker timestampDateTimePicker;
    }
}