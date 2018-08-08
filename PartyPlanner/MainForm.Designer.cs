namespace PartyPlanner
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
            this.grpNewParty = new System.Windows.Forms.GroupBox();
            this.btnCreateParty = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtMaxNum = new System.Windows.Forms.TextBox();
            this.lblCostPerPerson = new System.Windows.Forms.Label();
            this.lblTotalGuests = new System.Windows.Forms.Label();
            this.grpAddGuests = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lstGuestList = new System.Windows.Forms.ListBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblNumberofGuests = new System.Windows.Forms.Label();
            this.lblTotalCostOutput = new System.Windows.Forms.Label();
            this.lblTotalGuestsOutput = new System.Windows.Forms.Label();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblGuestList = new System.Windows.Forms.Label();
            this.grpNewParty.SuspendLayout();
            this.grpAddGuests.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNewParty
            // 
            this.grpNewParty.Controls.Add(this.btnCreateParty);
            this.grpNewParty.Controls.Add(this.txtAmount);
            this.grpNewParty.Controls.Add(this.txtMaxNum);
            this.grpNewParty.Controls.Add(this.lblCostPerPerson);
            this.grpNewParty.Controls.Add(this.lblTotalGuests);
            this.grpNewParty.Location = new System.Drawing.Point(31, 84);
            this.grpNewParty.Name = "grpNewParty";
            this.grpNewParty.Size = new System.Drawing.Size(742, 337);
            this.grpNewParty.TabIndex = 0;
            this.grpNewParty.TabStop = false;
            this.grpNewParty.Text = "New Party";
            // 
            // btnCreateParty
            // 
            this.btnCreateParty.Location = new System.Drawing.Point(283, 233);
            this.btnCreateParty.Name = "btnCreateParty";
            this.btnCreateParty.Size = new System.Drawing.Size(248, 67);
            this.btnCreateParty.TabIndex = 4;
            this.btnCreateParty.Text = "Create List";
            this.btnCreateParty.UseVisualStyleBackColor = true;
            this.btnCreateParty.Click += new System.EventHandler(this.btnCreateParty_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(423, 141);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(273, 44);
            this.txtAmount.TabIndex = 3;
            // 
            // txtMaxNum
            // 
            this.txtMaxNum.Location = new System.Drawing.Point(423, 67);
            this.txtMaxNum.Name = "txtMaxNum";
            this.txtMaxNum.Size = new System.Drawing.Size(273, 44);
            this.txtMaxNum.TabIndex = 2;
            // 
            // lblCostPerPerson
            // 
            this.lblCostPerPerson.AutoSize = true;
            this.lblCostPerPerson.Location = new System.Drawing.Point(140, 141);
            this.lblCostPerPerson.Name = "lblCostPerPerson";
            this.lblCostPerPerson.Size = new System.Drawing.Size(260, 37);
            this.lblCostPerPerson.TabIndex = 1;
            this.lblCostPerPerson.Text = "Cost Per Person:";
            // 
            // lblTotalGuests
            // 
            this.lblTotalGuests.AutoSize = true;
            this.lblTotalGuests.Location = new System.Drawing.Point(32, 67);
            this.lblTotalGuests.Name = "lblTotalGuests";
            this.lblTotalGuests.Size = new System.Drawing.Size(368, 37);
            this.lblTotalGuests.TabIndex = 0;
            this.lblTotalGuests.Text = "Total Number of Guests:";
            // 
            // grpAddGuests
            // 
            this.grpAddGuests.Controls.Add(this.btnAdd);
            this.grpAddGuests.Controls.Add(this.txtLastName);
            this.grpAddGuests.Controls.Add(this.txtFirstName);
            this.grpAddGuests.Controls.Add(this.lblLastName);
            this.grpAddGuests.Controls.Add(this.lblFirstName);
            this.grpAddGuests.Location = new System.Drawing.Point(31, 460);
            this.grpAddGuests.Name = "grpAddGuests";
            this.grpAddGuests.Size = new System.Drawing.Size(742, 383);
            this.grpAddGuests.TabIndex = 1;
            this.grpAddGuests.TabStop = false;
            this.grpAddGuests.Text = "Invite Guest";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(283, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(248, 79);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(423, 154);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(273, 44);
            this.txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(423, 66);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(273, 44);
            this.txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(202, 154);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(182, 37);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(202, 66);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(184, 37);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // lstGuestList
            // 
            this.lstGuestList.FormattingEnabled = true;
            this.lstGuestList.ItemHeight = 37;
            this.lstGuestList.Location = new System.Drawing.Point(807, 102);
            this.lstGuestList.Name = "lstGuestList";
            this.lstGuestList.Size = new System.Drawing.Size(484, 855);
            this.lstGuestList.TabIndex = 2;
            this.lstGuestList.SelectedIndexChanged += new System.EventHandler(this.lstGuestList_SelectedIndexChanged);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(272, 867);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(173, 37);
            this.lblTotalCost.TabIndex = 3;
            this.lblTotalCost.Text = "Total Cost:";
            // 
            // lblNumberofGuests
            // 
            this.lblNumberofGuests.AutoSize = true;
            this.lblNumberofGuests.Location = new System.Drawing.Point(170, 948);
            this.lblNumberofGuests.Name = "lblNumberofGuests";
            this.lblNumberofGuests.Size = new System.Drawing.Size(287, 37);
            this.lblNumberofGuests.TabIndex = 4;
            this.lblNumberofGuests.Text = "Number of Guests:";
            // 
            // lblTotalCostOutput
            // 
            this.lblTotalCostOutput.AutoSize = true;
            this.lblTotalCostOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCostOutput.Location = new System.Drawing.Point(499, 866);
            this.lblTotalCostOutput.Name = "lblTotalCostOutput";
            this.lblTotalCostOutput.Size = new System.Drawing.Size(116, 39);
            this.lblTotalCostOutput.TabIndex = 5;
            this.lblTotalCostOutput.Text = "Output";
            // 
            // lblTotalGuestsOutput
            // 
            this.lblTotalGuestsOutput.AutoSize = true;
            this.lblTotalGuestsOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalGuestsOutput.Location = new System.Drawing.Point(499, 948);
            this.lblTotalGuestsOutput.Name = "lblTotalGuestsOutput";
            this.lblTotalGuestsOutput.Size = new System.Drawing.Size(116, 39);
            this.lblTotalGuestsOutput.TabIndex = 6;
            this.lblTotalGuestsOutput.Text = "Output";
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(807, 987);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(222, 73);
            this.btnChange.TabIndex = 7;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1052, 987);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(229, 73);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblGuestList
            // 
            this.lblGuestList.AutoSize = true;
            this.lblGuestList.Location = new System.Drawing.Point(972, 43);
            this.lblGuestList.Name = "lblGuestList";
            this.lblGuestList.Size = new System.Drawing.Size(161, 37);
            this.lblGuestList.TabIndex = 9;
            this.lblGuestList.Text = "Guest List";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1430, 1080);
            this.Controls.Add(this.lblGuestList);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblTotalGuestsOutput);
            this.Controls.Add(this.lblTotalCostOutput);
            this.Controls.Add(this.lblNumberofGuests);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.lstGuestList);
            this.Controls.Add(this.grpAddGuests);
            this.Controls.Add(this.grpNewParty);
            this.Name = "MainForm";
            this.Text = "Party Organizer";
            this.grpNewParty.ResumeLayout(false);
            this.grpNewParty.PerformLayout();
            this.grpAddGuests.ResumeLayout(false);
            this.grpAddGuests.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNewParty;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtMaxNum;
        private System.Windows.Forms.Label lblCostPerPerson;
        private System.Windows.Forms.Label lblTotalGuests;
        private System.Windows.Forms.GroupBox grpAddGuests;
        private System.Windows.Forms.ListBox lstGuestList;
        private System.Windows.Forms.Button btnCreateParty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.Label lblNumberofGuests;
        private System.Windows.Forms.Label lblTotalCostOutput;
        private System.Windows.Forms.Label lblTotalGuestsOutput;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblGuestList;
    }
}

