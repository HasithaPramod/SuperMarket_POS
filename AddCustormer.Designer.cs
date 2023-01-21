namespace hasitha
{
    partial class AddCustormer
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
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lbltoplabel = new System.Windows.Forms.Label();
            this.lblcuthistorylabel = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.grboxCusthistory = new System.Windows.Forms.Panel();
            this.dtgviewCusttrxHistory = new System.Windows.Forms.DataGridView();
            this.lnkCustomers = new System.Windows.Forms.LinkLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCustID = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMsg = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.CombPeopleType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.grboxCusthistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewCusttrxHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltoplabel
            // 
            this.lbltoplabel.AutoSize = true;
            this.lbltoplabel.Location = new System.Drawing.Point(525, 6);
            this.lbltoplabel.Name = "lbltoplabel";
            this.lbltoplabel.Size = new System.Drawing.Size(265, 13);
            this.lbltoplabel.TabIndex = 1;
            this.lbltoplabel.Text = "Click top fo the row to view details due payment history";
            this.lbltoplabel.Visible = false;
            // 
            // lblcuthistorylabel
            // 
            this.lblcuthistorylabel.AutoSize = true;
            this.lblcuthistorylabel.Location = new System.Drawing.Point(3, 6);
            this.lblcuthistorylabel.Name = "lblcuthistorylabel";
            this.lblcuthistorylabel.Size = new System.Drawing.Size(150, 13);
            this.lblcuthistorylabel.TabIndex = 0;
            this.lblcuthistorylabel.Text = "Customer\'s Transaction history";
            this.lblcuthistorylabel.Visible = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.lbltoplabel);
            this.splitContainer2.Panel1.Controls.Add(this.lblcuthistorylabel);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.grboxCusthistory);
            this.splitContainer2.Size = new System.Drawing.Size(800, 200);
            this.splitContainer2.SplitterDistance = 25;
            this.splitContainer2.TabIndex = 19;
            // 
            // grboxCusthistory
            // 
            this.grboxCusthistory.Controls.Add(this.dtgviewCusttrxHistory);
            this.grboxCusthistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grboxCusthistory.Location = new System.Drawing.Point(0, 0);
            this.grboxCusthistory.Name = "grboxCusthistory";
            this.grboxCusthistory.Size = new System.Drawing.Size(800, 171);
            this.grboxCusthistory.TabIndex = 1;
            this.grboxCusthistory.Visible = false;
            // 
            // dtgviewCusttrxHistory
            // 
            this.dtgviewCusttrxHistory.AllowUserToAddRows = false;
            this.dtgviewCusttrxHistory.AllowUserToDeleteRows = false;
            this.dtgviewCusttrxHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgviewCusttrxHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgviewCusttrxHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgviewCusttrxHistory.Location = new System.Drawing.Point(0, 0);
            this.dtgviewCusttrxHistory.Name = "dtgviewCusttrxHistory";
            this.dtgviewCusttrxHistory.ReadOnly = true;
            this.dtgviewCusttrxHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgviewCusttrxHistory.Size = new System.Drawing.Size(800, 171);
            this.dtgviewCusttrxHistory.TabIndex = 0;
            this.toolTip1.SetToolTip(this.dtgviewCusttrxHistory, "Click to view Due payment");
            // 
            // lnkCustomers
            // 
            this.lnkCustomers.AutoSize = true;
            this.lnkCustomers.Location = new System.Drawing.Point(609, 221);
            this.lnkCustomers.Name = "lnkCustomers";
            this.lnkCustomers.Size = new System.Drawing.Size(71, 13);
            this.lnkCustomers.TabIndex = 0;
            this.lnkCustomers.TabStop = true;
            this.lnkCustomers.Text = "Customers list";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lnkCustomers);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.lblCustID);
            this.splitContainer1.Panel1.Controls.Add(this.txtCustomerName);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.lblMsg);
            this.splitContainer1.Panel1.Controls.Add(this.txtCustomerAddress);
            this.splitContainer1.Panel1.Controls.Add(this.CombPeopleType);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.txtEmailAddress);
            this.splitContainer1.Panel1.Controls.Add(this.txtCity);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.txtPhone);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 246;
            this.splitContainer1.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name   *";
            // 
            // lblCustID
            // 
            this.lblCustID.AutoSize = true;
            this.lblCustID.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.lblCustID.Location = new System.Drawing.Point(110, 18);
            this.lblCustID.Name = "lblCustID";
            this.lblCustID.Size = new System.Drawing.Size(8, 12);
            this.lblCustID.TabIndex = 1;
            this.lblCustID.Text = "-";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCustomerName.Location = new System.Drawing.Point(112, 49);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(277, 24);
            this.txtCustomerName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtCustomerName, "Customer Name");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(109, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "People Type *";
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Location = new System.Drawing.Point(439, 214);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(23, 16);
            this.lblMsg.TabIndex = 7;
            this.lblMsg.Text = "----";
            this.lblMsg.Visible = false;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCustomerAddress.Location = new System.Drawing.Point(406, 96);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(272, 66);
            this.txtCustomerAddress.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtCustomerAddress, "People Location Details");
            // 
            // CombPeopleType
            // 
            this.CombPeopleType.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.CombPeopleType.FormattingEnabled = true;
            this.CombPeopleType.Items.AddRange(new object[] {
            "",
            "Customer",
            "Supplier "});
            this.CombPeopleType.Location = new System.Drawing.Point(112, 141);
            this.CombPeopleType.Name = "CombPeopleType";
            this.CombPeopleType.Size = new System.Drawing.Size(277, 21);
            this.CombPeopleType.TabIndex = 3;
            this.toolTip1.SetToolTip(this.CombPeopleType, "Select People type Customer or Biller");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(403, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "City    *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(403, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address  *";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.btnSave.ForeColor = System.Drawing.Color.YellowGreen;
            this.btnSave.Location = new System.Drawing.Point(406, 183);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(272, 29);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.toolTip1.SetToolTip(this.btnSave, "I want to Submit");
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtEmailAddress.Location = new System.Drawing.Point(112, 183);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(277, 24);
            this.txtEmailAddress.TabIndex = 4;
            this.toolTip1.SetToolTip(this.txtEmailAddress, "People Email address");
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtCity.Location = new System.Drawing.Point(406, 49);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(272, 24);
            this.txtCity.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txtCity, "People City");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phone  *";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txtPhone.Location = new System.Drawing.Point(112, 96);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(277, 24);
            this.txtPhone.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtPhone, "Customer Contact Number");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(109, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Email Address";
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 800;
            this.toolTip1.AutoPopDelay = 8000;
            this.toolTip1.InitialDelay = 9;
            this.toolTip1.ReshowDelay = 9;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // AddCustormer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCustormer";
            this.Text = "AddCustormer";
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.grboxCusthistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgviewCusttrxHistory)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lbltoplabel;
        private System.Windows.Forms.Label lblcuthistorylabel;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel grboxCusthistory;
        private System.Windows.Forms.DataGridView dtgviewCusttrxHistory;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel lnkCustomers;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCustID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMsg;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.ComboBox CombPeopleType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label8;
    }
}